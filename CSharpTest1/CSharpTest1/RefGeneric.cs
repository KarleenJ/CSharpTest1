using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTest1
{
    //Question 5
    class RefGeneric<T> where T: class
    {
        public static void PrintValue(T value)
        {
            Console.WriteLine(value);
        }
    }    
}
