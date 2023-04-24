namespace Programa06_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Today.AddDays(1);
            string formato = "MMM ddd d HH mm yyyy";

            lblFecha.Text = fecha.ToString(formato);  
        }
    }
}