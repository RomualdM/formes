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
    public class DessinateurRectangle : Dessinateur
    {
      

       public void dessiner(Control p, Forme r)
        {
            Rectangle r1 = (Rectangle)r;
            
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
            System.Drawing.Graphics formGraphics = p.CreateGraphics();
            
            formGraphics.FillRectangle(myBrush,r1.LaPosition.X,r1.LaPosition.Y,r1.Longueur,r1.Largeur);
            myBrush.Dispose();

        }
    }
}
