﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Doctor : IDoctor
    {
        public string Name { get; set; }
        public void GetData()
        {
            Console.WriteLine("Please Enter Doctor Name :");
            this.Name = Console.ReadLine();
        }

        public void PutData()
        {
            Console.WriteLine("Doctor Name = " + this.Name);
        }
    }
}
