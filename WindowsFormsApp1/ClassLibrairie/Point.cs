using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrairie
{
    public class Point
    {
        private float x;
        private float y;

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
