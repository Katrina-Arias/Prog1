namespace Programa05_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chlbAlimentos.Items.Add("Carne");
            chlbAlimentos.Items.Add("Pescado", true);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            chlbAlimentos.Items.Add(txtNuevoALimento.Text);
        }

        private void chlbAlimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = chlbAlimentos.SelectedIndex; 

            if ( indice!=-1)
            {
                lblNombre.Text = chlbAlimentos.Items[indice].ToString(); 
            }

            if (chlbAlimentos.GetItemChecked(3)==true);
            MessageBox.Show("El pescado es bueno"); 
        }
    }
}