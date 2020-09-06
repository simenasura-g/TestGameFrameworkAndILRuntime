using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    /// <summary>
    /// 学生信息实体
    /// </summary>
    public class Student {
        public int ID { get; set; }
        public string Name { get; set; }
        public Class Class { get; set; }
    }
    /// <summary>
    /// 学生班级实体
    /// </summary>
    public class Class {
        public int ID { get; set; }
        public string Name { get; set; }
    }
