﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeusPalace
{
    public class Employee : User
    {
        public override UserRole Role => UserRole.Employee;

        public Employee(string name)
        {
            Name = name;
        }
    }
}
