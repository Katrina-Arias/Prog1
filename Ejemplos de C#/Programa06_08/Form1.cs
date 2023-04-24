namespace Programa06_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = txtMensaje.Text; 
        }
    }
}