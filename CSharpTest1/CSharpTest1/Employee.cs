using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CSharpTest1
{
    //Question 2
    class Employee
    {
        public int id;
        public string name;
        public int salary;

        public Employee(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;

        }
        
        public override string ToString()
        {
            return $"name = {this.name}";
        }
       


    }

}
