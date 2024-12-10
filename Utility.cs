using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace ocpp;

public static class Utility
{
    public static bool ValidateJSON(string json, string schema)
    {
        JSchema s = JSchema.Parse(schema);
        JArray a = JArray.Parse(json);
        JObject j = a[2] as JObject;
        return j.IsValid(s);
    }
}
