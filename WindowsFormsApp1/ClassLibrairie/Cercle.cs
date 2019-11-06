using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrairie
{
    public class Cercle : Forme
    {
        private float rayon;

        public float Rayon { get => rayon; set => rayon = value; }

        public Cercle(  float r,float x,float y) : base(x,y)
        {
            this.rayon = r;
           
            this.LaPosition = new Point(x, y);
        }

        protected override double perimetre()
        {
            return 2 * Math.PI * this.rayon;
        }
        protected override double surface()
        {
            return Math.PI * (this.rayon * this.rayon);
        }
    }
}
