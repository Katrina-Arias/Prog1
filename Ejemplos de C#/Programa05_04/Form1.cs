namespace Programa05_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dupFrutas.Items.Add("Melon");
            dupFrutas.Items.Add("Manzana");

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            dupFrutas.Items.Add(txtFruta.Text);

            txtFruta.Text = "";
        }

        private void dupFrutas_SelectedItemChanged(object sender, EventArgs e)
        {
            string fruta = (string)dupFrutas.SelectedItem;

            lblMensaje.Text = string.Format("Tu fruta favorita es {0}, muy sabrosa", fruta);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int indice = dupFrutas.SelectedIndex;

            dupFrutas.Items.RemoveAt(indice);
            dupFrutas.SelectedIndex = 0; 
        }
    }
}