using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrairie
{
   public class Carre : Forme
    {
        private float cote;

        public float Cote { get => cote; set => cote = value; }

        public Carre(float c,float x, float y) : base(x,y)
        {
            this.cote = c;
            
            this.LaPosition = new Point(x, y);
        }

        protected override double perimetre()
        {
            return this.cote * 4;
        }
        protected override double surface()
        {
            return this.cote * this.cote;
        }
    }
}
