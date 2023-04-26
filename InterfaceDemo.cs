using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface InterfaceDemo1
    {
        public void Test();
    } 

    public interface InterfaceDemo2
    {
        public void Test();
    }

    public class Employee : InterfaceDemo1, InterfaceDemo2
    { 
        void InterfaceDemo1.Test()
        {
            Console.WriteLine("InterfaceDemo1 Inside Employee Class Test Method");
        }

        void InterfaceDemo2.Test()
        {
            Console.WriteLine("InterfaceDemo2 Inside Employee Class Test Method");
        }
    }

}
 