using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrairie
{
    public abstract class Forme
    {
        protected string id;
        private Point laPosition;

        public Forme(float x,float y)
        {
            
            this.laPosition = new Point(x,y);
        }

        public string Id { get => id; set => id = value; }
        internal Point LaPosition { get => laPosition; set => laPosition = value; }

         abstract protected double perimetre();
         abstract protected double surface();



    }
}
