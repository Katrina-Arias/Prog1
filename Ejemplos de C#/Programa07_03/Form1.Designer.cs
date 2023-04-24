namespace Programa07_03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            monthCalendar1 = new MonthCalendar();
            lblInicio = new Label();
            lblFinal = new Label();
            btnFechas = new Button();
            lblSeleccion = new Label();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.BoldedDates = (new DateTime[] { new DateTime(0L), new DateTime(2023, 4, 22, 0, 0, 0, 0) });
            monthCalendar1.Location = new Point(18, 27);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Location = new Point(18, 254);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(50, 20);
            lblInicio.TabIndex = 1;
            lblInicio.Text = "label1";
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.Location = new Point(18, 301);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(50, 20);
            lblFinal.TabIndex = 2;
            lblFinal.Text = "label1";
            // 
            // btnFechas
            // 
            btnFechas.Location = new Point(346, 27);
            btnFechas.Name = "btnFechas";
            btnFechas.Size = new Size(153, 29);
            btnFechas.TabIndex = 3;
            btnFechas.Text = "Seleccionar fechas";
            btnFechas.UseVisualStyleBackColor = true;
            btnFechas.Click += btnFechas_Click;
            // 
            // lblSeleccion
            // 
            lblSeleccion.AutoSize = true;
            lblSeleccion.Location = new Point(18, 355);
            lblSeleccion.Name = "lblSeleccion";
            lblSeleccion.Size = new Size(50, 20);
            lblSeleccion.TabIndex = 4;
            lblSeleccion.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 466);
            Controls.Add(lblSeleccion);
            Controls.Add(btnFechas);
            Controls.Add(lblFinal);
            Controls.Add(lblInicio);
            Controls.Add(monthCalendar1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Label lblInicio;
        private Label lblFinal;
        private Button btnFechas;
        private Label lblSeleccion;
    }
}