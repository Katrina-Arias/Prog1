namespace Programa07_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.BoldedDates = new DateTime[]
            {
                new DateTime(2023,5,23),
                new DateTime(2023, 4, 19),
                DateTime.Today.AddDays(5),

            };
        }

        private void btnFechas_Click(object sender, EventArgs e)
        {
            DateTime inicio = monthCalendar1.SelectionStart;
            DateTime final = monthCalendar1.SelectionEnd;

            lblInicio.Text = inicio.ToString();
            lblFinal.Text = final.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblSeleccion.Text = monthCalendar1.SelectionRange.ToString(); 
        }
    }
}