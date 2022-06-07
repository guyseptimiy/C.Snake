﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class HorizontalLine
    {
        List<Point> plist;

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            plist = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                plist.Add(new Point(x, y, sym));
            }
        }
        public void Draw() 
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }
    }
}
