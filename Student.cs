using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtClass
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        
        public Student()
        {

        }
        public Student(string id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Age: {Age} \n";
        }
    }
}
