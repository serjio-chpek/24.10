using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Vector3
    {
        public int X;
        public int Y;
        public int Z;


        public Vector3()
        {
            Y = 0;
            X = 0;
            Z = 0;
        }

        public Vector3(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
