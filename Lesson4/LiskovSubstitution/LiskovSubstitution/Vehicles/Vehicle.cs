﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiskovSubstitution.Interfaces;

namespace LiskovSubstitution.Vehicles
{
    public class Vehicle : Perfomance
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("The engine is starting");
        }
    }
}
