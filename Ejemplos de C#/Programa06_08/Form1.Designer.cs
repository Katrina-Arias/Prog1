namespace Programa06_08
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
            txtMensaje = new TextBox();
            btnMostrar = new Button();
            lblMensaje = new Label();
            helpProvider1 = new HelpProvider();
            SuspendLayout();
            // 
            // txtMensaje
            // 
            helpProvider1.SetHelpString(txtMensaje, "COloca aquí el mensaje que deseas mostrar");
            txtMensaje.Location = new Point(44, 46);
            txtMensaje.Name = "txtMensaje";
            helpProvider1.SetShowHelp(txtMensaje, true);
            txtMensaje.Size = new Size(125, 27);
            txtMensaje.TabIndex = 0;
            // 
            // btnMostrar
            // 
            helpProvider1.SetHelpString(btnMostrar, "Este botón muestra el mensaje");
            btnMostrar.Location = new Point(304, 47);
            btnMostrar.Name = "btnMostrar";
            helpProvider1.SetShowHelp(btnMostrar, true);
            btnMostrar.Size = new Size(94, 29);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(55, 118);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(50, 20);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 432);
            Controls.Add(lblMensaje);
            Controls.Add(btnMostrar);
            Controls.Add(txtMensaje);
            HelpButton = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMensaje;
        private HelpProvider helpProvider1;
        private Button btnMostrar;
        private Label lblMensaje;
    }
}