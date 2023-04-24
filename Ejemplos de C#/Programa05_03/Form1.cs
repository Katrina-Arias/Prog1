namespace Programa05_03
{
    public partial class Form1 : Form
    {
        private int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Adicionar nuevo Renglón
            int n = dtgvProductos.Rows.Add();

            //Colocamos la informacion 
            dtgvProductos.Rows[n].Cells[0].Value = txtCodigo.Text;
            dtgvProductos.Rows[n].Cells[1].Value = txtNombre.Text;
            dtgvProductos.Rows[n].Cells[2].Value = txtPrecio.Text;

            //Limpiamos los txt
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";

        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n != -1)
            {
                lblInformacion.Text = (string)dtgvProductos.Rows[n].Cells[1].Value;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (n!=-1)
            {
                dtgvProductos.Rows.RemoveAt(n);
            }
        }
    }
}