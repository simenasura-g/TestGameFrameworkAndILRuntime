using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using URandom = UnityEngine.Random;

public class Log {
    public static void e(string msg) {
        Debug.LogError(msg);
    }

    public static void e(string msg, params object[] args) {
        e(string.Format(msg, args));
    }

    public static void i(string msg) {
        Debug.Log(msg);
    }

    public static void w(string msg) {
        Debug.LogWarning(msg);
    }
    public static void w(string msg, params object[] args) {
        w(string.Format(msg, args));
    }

    private const string format = "<color=#{0}><size={1}>\n{2}\n</size></color>";
    private const int size = 15;


    public static void f(string msg, params object[] args) {
#if UNITY_EDITOR
        c(string.Format(msg, args));
#else
        Debug.Log(string.Format(msg, args));
#endif
    }

    public static void c(string msg) {
#if UNITY_EDITOR
        Debug.Log(string.Format(format, GetHEXColor(), size, msg));
#else
        Debug.Log(msg);
#endif
    }

    public static void c(params object[] args) {
        var bs = ", ";
        var msg = args[0] + bs;
        for (int i = 1; i < args.Length; i++) {
            msg += args[i] + bs;
        }
        if (args.Length > 1) {
            msg.Remove(msg.Length - 3);
        }
        c(msg);
    }

    public static void a(object[] msgs) {
        var msg = "";
        foreach (var obj in msgs) {
            msg += obj.ToString() + "\n";
        }
        c(msg);
    }

    public static void a(List<object> msgs) {
        var msg = "";
        foreach (var obj in msgs) {
            msg += obj.ToString() + "\n";
        }
        c(msg);
    }

    public static void a(List<string> msgs) {
        var msg = "";
        foreach (var str in msgs) {
            msg += str + "\n";
        }
        c(msg);
    }
    public static void a(List<int> msgs) {
        var msg = "";
        foreach (var str in msgs) {
            msg += str + "\n";
        }
        c(msg);
    }

    public static void a(Vector3[] points) {
        var msg = "";
        for (int i = 0; i < points.Length; i++) {
            msg += i + " : " + points[i] + ",\n";
        }
        c(msg);
    }

    //public static void a(List<Point> points) {
    //    var msg = "";
    //    for (int i = 0; i < points.Count; i++) {
    //        msg += points[i].ToString() + "\n";
    //    }
    //    c(msg);
    //}

    public static string ToStr(string[] objs) {
        var str = "";
        for (int i = 0; i < objs.Length; i++) {
            str += objs[i].ToString() + ", ";
        }
        return str;
    }

    public static string ToStr(int[] objs) {
        var str = "";
        for (int i = 0; i < objs.Length; i++) {
            str += objs[i].ToString() + ", ";
        }
        return str;
    }

    public static string ToStr(object[] objs) {
        var str = "";
        for (int i = 0; i < objs.Length; i++) {
            str += objs[i].ToString() + ", ";
        }
        return str;
    }

    public static string ToStr(List<int> objs) {
        var str = "";
        for (int i = 0; i < objs.Count; i++) {
            str += objs[i].ToString() + ", ";
        }
        return str;
    }

    public static string ToStr(List<string> objs) {
        var str = "";
        for (int i = 0; i < objs.Count; i++) {
            str += objs[i].ToString() + ", ";
        }
        return str;
    }

    public static string ToStr(List<object> objs) {
        var str = "";
        for (int i = 0; i < objs.Count; i++) {
            str += objs[i].ToString() + ", ";
        }
        return str;
    }

    public static void t(string msg) {
#if UNITY_EDITOR
            UnityEditor.EditorUtility.DisplayDialog("提示", msg, "确认");
#endif
    }

    public static void write(string msg, string title = "") {
        string LogPath = Application.dataPath + "/fuck.log";
        //if (!Directory.Exists(LogPath)) {
        //    Directory.CreateDirectory(LogPath);
        //}
        //string filename = (DateTime.Now.ToString().Replace('/', '-')).Replace(' ', '-') + title + ".log";
        //File.Create(LogPath + filename);
        //FileStream fs = new FileStream(LogPath + filename, FileMode.Append);
        FileStream fs = new FileStream(LogPath, FileMode.Append);
        StreamWriter writer = new StreamWriter(fs);
        writer.Write(msg);
        writer.Flush();
        writer.Close();
        fs.Close();
    }

    public static Color GetColor() {
        var r = URandom.Range(1, 255) / 255f;
        var g = URandom.Range(1, 255) / 255f;
        var b = URandom.Range(1, 255) / 255f;
        return new Color(r, g, b);
    }

    public static string GetHEXColor() {
        var r = URandom.Range(100, 255).ToString("x2");
        var g = URandom.Range(100, 255).ToString("x2");
        var b = URandom.Range(100, 255).ToString("x2");
        return r + g + b;
    }
}
