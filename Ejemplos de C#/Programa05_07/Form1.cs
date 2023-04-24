namespace Programa05_07
{
    public partial class Form1 : Form
    {
        private int indice;

        public Form1()
        {
            InitializeComponent();
            indice = 0;
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            indice++;

            if (indice > 1)
                indice = 0;

            lblFoto.ImageIndex = indice;

            pctbImagen.Image = imglFotos.Images[indice];
        }
        private void form1_load(object sender, EventArgs e)
        {
            pctbImagen.Image = imglFotos.Images[0];
        }

    }
}