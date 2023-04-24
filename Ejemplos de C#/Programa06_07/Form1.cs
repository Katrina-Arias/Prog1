namespace Programa06_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Font miFuente = new Font("Arial", 16.0f, FontStyle.Bold|FontStyle.Italic);

            //lblMensaje.Font = miFuente; 
        }

        private void btnFuente_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog()==DialogResult.OK)
            {
                lblMensaje.Font = fontDialog1.Font; 
            }
        }
    }
}