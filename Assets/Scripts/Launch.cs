using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFramework;
using Newtonsoft.Json;
using System.IO;

public class Launch : MonoBehaviour {
    void Start() {
        Utility.Json.SetJsonHelper(new JsonParse());

        //var path = Utility.Path.GetRegularPath(Application.dataPath + "/Scripts/testjson.json");
        //var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
        //var json = string.Empty;
        //using(var sr = new StreamReader(fs)) {
        //    json = sr.ReadToEnd();
        //    sr.Close();
        //}
        //Log.c(json);
        //fs.Close();

        var json = Utility.Json.ReadJsonFromPath(Application.dataPath + "/Scripts/testjson.json");
        //var list = JsonConvert.DeserializeObject<List<Student>>(json);
        var list = Utility.Json.ToObject<List<Student>>(json);
        Log.c("Student count is ", list.Count);

        for (var i = 0; i < list.Count; i++) {
            var student = list[i];
            //Log.c(string.Format("student.id = {0}, name = {1}, class.id = {2}, name = {3}", student.ID, student.Name, student.Class.ID, student.Class.Name));
            Log.f("student.id = {0}, name = {1}, class.id = {2}, name = {3}", student.ID, student.Name, student.Class.ID, student.Class.Name);
        }
    }

    void Update() {
        
    }
}
