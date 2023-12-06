using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
    internal class Student
    {
        private string name;
        private int age;
        private string major;

        public Student(string name, int age, string major)
        {
            this.name = name;
            this.age = age;
            this.major = major;
        }
        public string introduce()
        {
            return $"name: {name}, age: {age}, major: {major}";
        }
    }
}
