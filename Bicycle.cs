﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }
}
