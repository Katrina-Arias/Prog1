namespace Proyecto05_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Adicionar elementos 
            lstFrutas.Items.Add("Banana");
            lstFrutas.Items.Add("Durazno");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            lstFrutas.Items.Add(txtFruta.Text);

            txtFruta.Text = string.Empty;
        }

        private void lstFrutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstFrutas.SelectedIndex!=-1)
            lblFruta.Text = (string)lstFrutas.Items[lstFrutas.SelectedIndex];
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = lstFrutas.SelectedIndex; 
            
            if(indice!=-1)
            {
                lstFrutas.Items.RemoveAt(indice); 
            }
        }
    }
}