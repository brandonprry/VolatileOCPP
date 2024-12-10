using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace ocpp;

public static class Utility
{
    public static bool ValidateJSON(JObject json, string schema)
    {
        JSchema s = JSchema.Parse(schema);
        return json.IsValid(s);
    }
}
