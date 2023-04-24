namespace Programa06_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;

            lblFecha.Text = fecha.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double dias = Convert.ToDouble(txtDias.Text);

            dateTimePicker1.Value = DateTime.Today.AddDays(dias); 
        }
    }
}