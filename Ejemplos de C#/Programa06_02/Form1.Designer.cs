namespace Programa06_02
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
            lblFecha = new Label();
            btnOperaciones = new Button();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(276, 69);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 20);
            lblFecha.TabIndex = 0;
            // 
            // btnOperaciones
            // 
            btnOperaciones.Location = new Point(250, 108);
            btnOperaciones.Name = "btnOperaciones";
            btnOperaciones.Size = new Size(94, 29);
            btnOperaciones.TabIndex = 1;
            btnOperaciones.Text = "Operaciones";
            btnOperaciones.UseVisualStyleBackColor = true;
            btnOperaciones.Click += btnOperaciones_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOperaciones);
            Controls.Add(lblFecha);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Button btnOperaciones;
    }
}