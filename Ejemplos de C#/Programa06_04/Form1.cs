namespace Programa06_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            bool error = false; 

            foreach(char caracter in txtDato.Text)
            {
                if (char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }
            //Verificamos por la condición de error
            if (error)
            {
                errorProvider1.SetError(txtDato, "No se admiten numeros"); 
            }
            else 
                errorProvider1.Clear(); 
        }
    }
}