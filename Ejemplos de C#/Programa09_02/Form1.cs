using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa09_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Ejemplo 1

            //Dibujamos una elipse

            //Pens contiene plumar pre-creadas
            //Rectangle representa a un rectangulo
            //Los primeros parametros son las coordenadas de la esq. sup izq
            //Los dos siguientes son el ancho y el alto del rectangulo

            g.DrawEllipse(Pens.Indigo, new Rectangle(50, 50, 100, 50));

            //Dibujamos en coordenadas de mundo y pixeles
            g.DrawEllipse(Pens.Red, new Rectangle(0, 0, 20, 20));

            //Hacemos un offset al origen
            g.TranslateTransform(100, 100);

            g.DrawEllipse(Pens.Blue, new Rectangle(0, 0, 20, 20));
            g.DrawEllipse(Pens.CadetBlue, new Rectangle(20, 0, 20, 20));

            //Fin ejemplo 1

            //Ejemplo 2

            //Coordenadas de mundo y pixeles
            g.DrawEllipse(Pens.Red, new Rectangle(0, 0, 20, 20));

            //Colocamos una nueva unidad de medida
            //Point 1/72 de pulgada
            //display 1/100 de pulgada, usada en impresoras
            //document 1/300 de pulgada

            g.PageUnit = GraphicsUnit.Millimeter;

            g.DrawEllipse(Pens.Blue, new Rectangle(1, 1, 20, 20));

            //Fin ejemplo 2
        }
    }
}
