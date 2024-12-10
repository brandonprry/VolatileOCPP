#!/usr/bin/env python2

import websocket
import json
import os
import threading
import subprocess
from argparse import Namespace
from websocket import create_connection
from pyjfuzz.lib import *
from JSONMessages import messages
from jsonschema import validate

dir = os.path.dirname(__file__)

def communicate(json_arr):
    print json_arr
    headers = {
       'Sec-WebSocket-Protocol': 'ocpp1.6'
    }
    ws = create_connection('ws://localhost:8180/steve/websocket/CentralSystemService/1', header=headers)
    ws.settimeout(0.05)
    ws.send(json_arr)

    try:
        result = ws.recv()
        return True
    except websocket.WebSocketTimeoutException:
        return ("Timeout")
    
    ws.close()
    
   # if "SQL" in os.popen("curl 'http://localhost:8180/steve/manager/transactions' -H 'User-Agent: Mozilla/5.0 (Macintosh; Intel Mac OS X 10.15; rv:131.0) Gecko/20100101 Firefox/131.0' -H 'Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/png,image/svg+xml,*/*;q=0.8' -H 'Accept-Language: en-US,en;q=0.5' -H 'Accept-Encoding: gzip, deflate, br, zstd' -H 'Connection: keep-alive' -H 'Referer: http://localhost:8180/steve/manager/home' -H 'Cookie: JSESSIONID=node0a2ytwx9oudft1v1s5mzeuvkbp1.node0' -H 'Upgrade-Insecure-Requests: 1' -H 'Sec-Fetch-Dest: document' -H 'Sec-Fetch-Mode: navigate' -H 'Sec-Fetch-Site: same-origin' -H 'Sec-Fetch-User: ?1' -H 'Priority: u=0, i'").read():
    #    exit ("Don't")

def __load_schema__(schema_type):
    files = os.listdir(os.path.join(os.path.dirname(__file__), "schemas/json"))
    files = [f for f in files if (schema_type == "response" and "Response" in f) or (schema_type != "response" and "Response" not in f)]

    with open(os.path.join(os.path.dirname(__file__), 'schemas/ocpp-schema-' + schema_type + '.json'), 'r') as myfile:
        data = myfile.read()

        parts = data.split("<loop>")
        for f in files:
            new_part = parts[1].replace("<action-name>", f.split(".")[0])
            new_part = new_part.replace("<action-schema>", f)
            parts.insert(2, new_part + ",")
        parts.pop(1)
        parts[-2] = parts[-2][:-1]
        schema_str = "".join(parts)
        return json.loads(schema_str)

def load_request_schema():
    return __load_schema__("request")

def load_response_schema():
    return __load_schema__("response")

def validate_schema(message, schema):
    json_list = {}
    try:
        json_list = json.loads(message)
    except Exception as e:
        return "JSON parsing error\n" + e.message
    try:
        validate(json_list, schema)
        return "OK"
    except Exception as e:
        return "Schema error\n" + e.message

def test():
    req_schema = load_request_schema()
    resp_schema = load_response_schema()
    t = threading.Thread(target=raw_input,args=("Press enter to quit...",))
    t.start()
    wf = open("results-chargetimeeu.txt", 'w')
    testf = open("generated-tests-chargetimeeu.txt", 'w')

    # Stats
    invalid_response = 0
    req_json_error_resp_timeout = 0
    req_json_error_resp_form_error = 0
    req_json_error_resp_other_error = 0
    req_json_error_resp_result = 0
    req_ocpp_error_resp_timeout = 0
    req_ocpp_error_resp_form_error = 0
    req_ocpp_error_resp_notimpl_error = 0
    req_ocpp_error_resp_other_error = 0
    req_ocpp_error_resp_result = 0
    req_valid_resp_timeout = 0
    req_valid_resp_error = 0
    req_valid_resp_result = 0

    if wf and testf:
        for m in messages:
            print "\n\nNew message:"
            wf.write("----------------- New message -----------------\n")
            testf.write("----------------- New message -----------------\n")
            communicate(json.dumps(m))
            if validate(m, req_schema) == None:
                print "Base message OK"
            for utf in [True, False]: # UTF8 insertion mode
                wf.write("- utf = " + str(utf) + " -\n")
                for s in [True, False]:
                    wf.write("-- strong fuzzing = " + str(s) + " --\n")
                    for l in range(1, 7): # Levels 1-6
                        wf.write("--- level = " + str(l) + " ---\n")
                        print("utf: {0} / strong fuzzing: {1} / level: {2}".format(utf, s, l))
                        testf.write("-- utf: {0} / strong fuzzing: {1} / level: {2} --\n".format(utf, s, l))
                        config = PJFConfiguration(Namespace(json=m, nologo=True, level=l, strong_fuzz=s, utf8=utf))
                        fuzzer = PJFFactory(config)
                        for i in range(50):
                            if not t.isAlive():
                                return
                            f = fuzzer.fuzzed

                            error = f + "\n"
                            result = communicate(f)
                            try:
                                validation_request = validate_schema(f, req_schema)
                                validation_result = validate_schema(result, resp_schema)
                                testf.write("Request: " + f + "\n")
                                testf.write("Response: " + result + "\n")
                                error += "Validity request: " + validation_request + "\n"
                                error += "Response: " + result + "\n"
                                error += "Validity response: " + validation_result + "\n"

                                if "OK" not in validation_result and result != "Timeout" and result:
                                    invalid_response += 1
                                    error += "Server response not valid"
                                    invalid_response += 1
                                    wf.write(error + "\n\n")
                                    continue

                                elif result == "Timeout" or not result:
                                    if "JSON parsing error" in validation_request:
                                        req_json_error_resp_timeout += 1
                                    elif "Schema error" in validation_request:
                                        req_ocpp_error_resp_timeout += 1
                                    else: # Syntactically valid request
                                        req_valid_resp_timeout += 1
                                        error += "Valid request timed out, check..."
                                        wf.write(error + "\n\n")
                                    continue

                                result = json.loads(result)

                                if result[0] != 3: # OCPP error message
                                    if "JSON parsing error" in validation_request:
                                        if result[0] == 4 and result[2] == "FormationViolation":
                                            req_json_error_resp_form_error += 1
                                        else:
                                            req_json_error_resp_other_error += 1
                                            error += "Syntax error in request not detected (JSON), check..."
                                            wf.write(error + "\n\n")

                                    elif "Schema error" in validation_request:
                                        if result[0] == 4 and result[2] == "FormationViolation":
                                            req_ocpp_error_resp_form_error += 1
                                        elif result[0] == 4 and result[2] == "NotImplemented":
                                            req_ocpp_error_resp_notimpl_error += 1
                                        else:
                                            req_ocpp_error_resp_other_error += 1
                                            error += "Syntax error in request not detected (OCPP), check..."
                                            wf.write(error + "\n\n")

                                    else:  # Syntactically valid request
                                        req_valid_resp_error += 1
                                        error += "Error message for valid request, check..."
                                        wf.write(error + "\n\n")

                                else: # OCPP result message
                                    if "JSON parsing error" in validation_request:
                                        req_json_error_resp_result += 1
                                        error += "Syntax error in request not detected (JSON), check..."
                                        wf.write(error + "\n\n")
                                    elif "Schema error" in validation_request:
                                        req_ocpp_error_resp_result += 1
                                        error += "Syntax error in request not detected (OCPP), check..."
                                        wf.write(error + "\n\n")
                                    else:  # Syntactically valid request
                                        req_valid_resp_result += 1
                            except Exception as e:
                                error += e.message + "\n"
                                error += "Result cannot be parsed!"
                                wf.write(error + "\n\n")

        wf.write("- Result stats -\n")
        wf.write("Response: Invalid "+ str(invalid_response)+ "\n")
        wf.write("Request: JSON syntax error; Response: Timeout "+ str(req_json_error_resp_timeout)+ "\n")
        wf.write("Request: JSON syntax error; Response: FormationViolation OCPP error message "+ str(req_json_error_resp_form_error)+ "\n")
        wf.write("Request: JSON syntax error; Response: Other OCPP error message "+ str(req_json_error_resp_other_error)+ "\n")
        wf.write("Request: JSON syntax error; Response: Result message "+ str(req_json_error_resp_result)+ "\n")
        wf.write("Request: OCPP syntax error (schema); Response: Timeout "+str(req_ocpp_error_resp_timeout)+ "\n")
        wf.write("Request: OCPP syntax error (schema); Response: FormationViolation OCPP error message "+str(req_ocpp_error_resp_form_error)+ "\n")
        wf.write("Request: OCPP syntax error (schema); Response: NotImplemented OCPP error message "+str(req_ocpp_error_resp_notimpl_error)+ "\n")
        wf.write("Request: OCPP syntax error (schema); Response: Other OCPP error message "+ str(req_ocpp_error_resp_other_error)+ "\n")
        wf.write("Request: OCPP syntax error (schema); Response: Result message "+ str(req_ocpp_error_resp_result)+ "\n")
        wf.write("Request: Syntactically valid; Response: Timeout "+ str(req_valid_resp_timeout)+ "\n")
        wf.write("Request: Syntactically valid; Response: Error message "+ str(req_valid_resp_error)+ "\n")
        wf.write("Request: Syntactically valid; Response: Result message "+ str(req_valid_resp_result)+ "\n")
        
        wf.close()
        testf.close()
        
    print("Finished, press key to exit")

test()
