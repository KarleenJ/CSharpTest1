using System;
using System.Collections.Generic;

namespace CSharpTest1
{
    class Program
    {
        public delegate int MinMaxSalary();

        static void Main(string[] args)
        {
            //Question 1: A;

            //Question 2:
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee(1, "John", 500));
            empList.Add(new Employee(2, "James", 600));
            empList.Add(new Employee(3, "Jane", 1000));
            empList.Add(new Employee(4, "Jack", 200));
            empList.Add(new Employee(5, "Jerry", 800));

            foreach (var emp in empList)
            {
                Console.WriteLine(emp.ToString());
            }

            //static int MinMaxSalary()
            //{
            //    return 1;

            //}

            //Question 3:
            var info = Tuple.Create<string, int, string>("John", 20, "123 Street");
            Console.WriteLine($"name: {info.Item1} age:{info.Item2} address: {info.Item3}");

            Console.WriteLine("name: {0}", info.Item1);
            Console.WriteLine("age: {0}", info.Item2);
            Console.WriteLine("address: {0}", info.Item3);


            //Question 4:





        }
    }

    
}
