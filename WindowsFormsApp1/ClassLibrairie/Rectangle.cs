using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrairie
{
    public class Rectangle : Forme
    {
        private float longueur;
        private float largeur;

        public float Longueur { get => longueur; set => longueur = value; }
        public float Largeur { get => largeur; set => largeur = value; }

        public Rectangle(float l,float L,float x,float y) : base(x,y)
        {
            this.longueur = l;
            this.largeur = L;
            
            this.LaPosition = new Point(x, y);
        }
        protected override double perimetre()
        {
            return 2 * this.longueur + 2 * this.largeur;
        }
        protected override double surface()
        {
            return this.longueur * this.largeur;
        }
    }
}
