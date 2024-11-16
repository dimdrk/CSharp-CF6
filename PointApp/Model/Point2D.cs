﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointApp.Model
{
    internal class Point2D : Point
    {
        public int Y {  get; set; }

        //      base constractor calls parent constractor  
        //public Point2D() : base()
        //{
        //    Y = 0;
        //}

        public Point2D() { }

        public Point2D(int x, int y) : base(x)
        {
            Y = y;
        }

        public override string? ToString()
        {
            return base.ToString() + " " + $"{{{Y}}}";
        }

        public override void Move10()
        {
            base.Move10();
            Y += 10;
        }
    }
}
