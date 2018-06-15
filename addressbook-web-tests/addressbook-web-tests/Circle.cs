﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressBookTests
{
    class Circle : Figure
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public int Radius
        {
            get
            {
                return radius*2; 
            }
            set
            {
                radius = value;
            }
        }
    }
}
