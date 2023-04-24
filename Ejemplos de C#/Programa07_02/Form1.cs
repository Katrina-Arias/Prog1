namespace Programa07_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = mtxtDato.Text;
        }

        private void mtxtDato_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            lblMensaje.Text = "Error al introducir el dato"; 
        }
    }
}