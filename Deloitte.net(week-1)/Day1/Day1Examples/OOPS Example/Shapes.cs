﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Example
{
    abstract class Shapes
    {
        protected double area;
        public abstract void DisplayArea();
        public virtual void DisplayShapes()
        {
            Console.WriteLine("This is shapes class");
        }

    }
}
