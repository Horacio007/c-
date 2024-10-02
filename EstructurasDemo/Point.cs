using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDemo
{
    public struct Point
    {
        public int X;
        int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int Calcular()
        {
            return X * Y;
        }
    }
}
