using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb4_Generics
{
    internal class Employee
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public string _gender { get; set; }
        public double _salary { get; set; }

        public Employee(int id, string name, string gender, double salary)
        {
            _id = id;
            _name = name;
            _gender = gender;
            _salary = salary;
        }
    }
}
