using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrairie
{
   public class DessinateurCercle : Dessinateur
    {
        public void dessiner(Control p, Forme r)
        {
            Cercle c1 = (Cercle)r;

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
            System.Drawing.Graphics formGraphics = p.CreateGraphics();
            Pen myPen = new Pen(Color.Green);
            formGraphics.DrawEllipse(myPen, c1.LaPosition.X, c1.LaPosition.Y, c1.Rayon,c1.Rayon);
            myBrush.Dispose();

        }

    }
}
