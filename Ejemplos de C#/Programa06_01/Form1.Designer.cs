namespace Programa06_01
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
            lblMensaje = new Label();
            btnColor = new Button();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(183, 36);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(95, 20);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "Hola a todos";
            // 
            // btnColor
            // 
            btnColor.Location = new Point(191, 92);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(94, 29);
            btnColor.TabIndex = 1;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 438);
            Controls.Add(btnColor);
            Controls.Add(lblMensaje);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
        private Button btnColor;
        private ColorDialog colorDialog1;
    }
}