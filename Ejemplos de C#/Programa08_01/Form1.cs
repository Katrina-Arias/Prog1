namespace Programa08_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirNotePad_Click(object sender, EventArgs e)
        {
            //nos permitimos recibir eventos del notepad
            prcNotePad.EnableRaisingEvents = true;

            //Arrancamos el proceso
            prcNotePad.Start();

            lblEstado.Text = "notepad Arrancado";
        }

        private void btnCerrarNotePad_Click(object sender, EventArgs e)
        {
            prcNotePad.Kill();

        }

        private void prcNotePad_Exited(object sender, EventArgs e)
        {
            //Este evento sucede cuando se cierra el proceso
            lblEstado.Text = "Notepad Cerrado";

            notifyIcon1.ShowBalloonTip(100, "Alerta", "Notepad Cerrado",ToolTipIcon.Info);

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostramos la forma
            this.Show();
        }

        private void esconderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Esconder forma
            this.Hide();
        }
    }
}