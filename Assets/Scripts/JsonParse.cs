using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using GameFramework;
using Newtonsoft.Json;

public class JsonParse : Utility.Json.IJsonHelper {
    public string ToJson(object obj) {
        var str = JsonConvert.SerializeObject(obj);
        return str;
    }

    public T ToObject<T>(string json) {
        var obj = (T)JsonConvert.DeserializeObject<T>(json);
        return obj;
    }

    public object ToObject(Type objectType, string json) {
        var obj = JsonConvert.DeserializeObject(json);
        return obj;
    }
}
