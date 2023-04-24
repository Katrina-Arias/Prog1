namespace Programa07_02
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
            btnMostrar = new Button();
            lblMensaje = new Label();
            mtxtDato = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(339, 33);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(94, 29);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(40, 100);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(50, 20);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "label1";
            // 
            // mtxtDato
            // 
            mtxtDato.Location = new Point(40, 35);
            mtxtDato.Mask = "00/00/0000 00:00";
            mtxtDato.Name = "mtxtDato";
            mtxtDato.Size = new Size(125, 27);
            mtxtDato.TabIndex = 3;
            mtxtDato.ValidatingType = typeof(DateTime);
            mtxtDato.MaskInputRejected += mtxtDato_MaskInputRejected;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 446);
            Controls.Add(mtxtDato);
            Controls.Add(lblMensaje);
            Controls.Add(btnMostrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnMostrar;
        private Label lblMensaje;
        private MaskedTextBox mtxtDato;
    }
}