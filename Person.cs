﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托比较数组中数字大小
{
    public class Person
    {
        public Person() { }
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }
        string name;
        int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
    }
}
