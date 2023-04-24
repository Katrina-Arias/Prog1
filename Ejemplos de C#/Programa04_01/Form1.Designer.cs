namespace Programa04_01
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
            components = new System.ComponentModel.Container();
            tmrPrueba = new System.Windows.Forms.Timer(components);
            lblValor = new Label();
            btnInicio = new Button();
            lblDetener = new Button();
            tbrIntervalo = new TrackBar();
            lbltValor = new Label();
            pbrTrabajo = new ProgressBar();
            btnCalculo = new Button();
            ((System.ComponentModel.ISupportInitialize)tbrIntervalo).BeginInit();
            SuspendLayout();
            // 
            // tmrPrueba
            // 
            tmrPrueba.Tick += tmrPrueba_Tick;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(37, 50);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(50, 20);
            lblValor.TabIndex = 0;
            lblValor.Text = "label1";
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(207, 12);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(94, 29);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // lblDetener
            // 
            lblDetener.Location = new Point(207, 65);
            lblDetener.Name = "lblDetener";
            lblDetener.Size = new Size(94, 29);
            lblDetener.TabIndex = 2;
            lblDetener.Text = "Detener";
            lblDetener.UseVisualStyleBackColor = true;
            lblDetener.Click += lblDetener_Click;
            // 
            // tbrIntervalo
            // 
            tbrIntervalo.Location = new Point(37, 138);
            tbrIntervalo.Maximum = 1000;
            tbrIntervalo.Minimum = 100;
            tbrIntervalo.Name = "tbrIntervalo";
            tbrIntervalo.Size = new Size(264, 56);
            tbrIntervalo.TabIndex = 3;
            tbrIntervalo.TickFrequency = 100;
            tbrIntervalo.Value = 100;
            tbrIntervalo.Scroll += tbrIntervalo_Scroll;
            // 
            // lbltValor
            // 
            lbltValor.AutoSize = true;
            lbltValor.Location = new Point(37, 92);
            lbltValor.Name = "lbltValor";
            lbltValor.Size = new Size(67, 20);
            lbltValor.TabIndex = 4;
            lbltValor.Text = "Intervalo";
            // 
            // pbrTrabajo
            // 
            pbrTrabajo.Location = new Point(37, 179);
            pbrTrabajo.Name = "pbrTrabajo";
            pbrTrabajo.Size = new Size(264, 29);
            pbrTrabajo.TabIndex = 5;
            // 
            // btnCalculo
            // 
            btnCalculo.Location = new Point(207, 225);
            btnCalculo.Name = "btnCalculo";
            btnCalculo.Size = new Size(94, 29);
            btnCalculo.TabIndex = 6;
            btnCalculo.Text = "Calcular";
            btnCalculo.UseVisualStyleBackColor = true;
            btnCalculo.Click += btnCalculo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 280);
            Controls.Add(btnCalculo);
            Controls.Add(pbrTrabajo);
            Controls.Add(lbltValor);
            Controls.Add(tbrIntervalo);
            Controls.Add(lblDetener);
            Controls.Add(btnInicio);
            Controls.Add(lblValor);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)tbrIntervalo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrPrueba;
        private Label lblValor;
        private Button btnInicio;
        private Button lblDetener;
        private TrackBar tbrIntervalo;
        private Label lbltValor;
        private ProgressBar pbrTrabajo;
        private Button btnCalculo;
    }
}