using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1 
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ClassLibrairie.DessinateurRectangle dr = new ClassLibrairie.DessinateurRectangle();
            float x = float.Parse(textBox1.Text);
            float y = float.Parse(textBox6.Text);
            float longueur = float.Parse(textBox5.Text);
            float largeur = float.Parse(textBox6.Text);
            ClassLibrairie.Rectangle r = new ClassLibrairie.Rectangle(x, y,longueur, largeur);
            dr.dessiner(panel1,r);

           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ClassLibrairie.DessinateurCercle dc = new ClassLibrairie.DessinateurCercle();
            ClassLibrairie.Cercle c = new ClassLibrairie.Cercle(float.Parse(textBox1.Text), float.Parse(textBox5.Text), float.Parse(textBox6.Text));
            dc.dessiner(panel1, c);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ClassLibrairie.DessinateurCarre dr = new ClassLibrairie.DessinateurCarre();
            ClassLibrairie.Carre r = new ClassLibrairie.Carre(float.Parse(textBox1.Text), float.Parse(textBox5.Text), float.Parse(textBox6.Text));
            dr.dessiner(panel1, r);
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
