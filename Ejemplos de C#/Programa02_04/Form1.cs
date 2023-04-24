using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            double costo = 0.0;
            string cotizacion = "";

            cotizacion = "Cotizacion de auto para " + txtNombre.Text;

            costo = Convert.ToDouble(txtCosto.Text);

            if (rbnBasico.Checked == true)
            {
                costo = costo + 500.0;
                cotizacion += "Lleva seguro basico de $500 \r\n";
            }
            if (rbnTerceros.Checked == true)
            {
                costo += 700.0;
                cotizacion = "Lleva seguro a terceros de $700 \r\n";
            }
            if (rbnTotal.Checked == true)
            {
                costo += 1000.0;
                cotizacion += "Lleva seguro total de $1000 \r\n";
            }

            //Verificar equipo

            if (chkAire.Checked == true)
            {
                costo += 500.0;
                cotizacion += "Con aire acondicionado de $500 \r\n";
            }
            if (chkAudio.Checked == true)
            {
                costo += 700.0;
                cotizacion += "Con sistema de audio de $700 \r\n";
            }

            //Mostramos total

            cotizacion += "El total a pagar es de " + costo.ToString();

            txtCotizacion.Text = cotizacion;
        }
    }
}
