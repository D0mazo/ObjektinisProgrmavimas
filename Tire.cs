﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    public class Tire
    {
        public double Pressure { get; set; }
        public int Age { get; set; }

        public Tire( double pressure, int age) 
        {
            Pressure = pressure;
            Age = age;
        }
    }
}
