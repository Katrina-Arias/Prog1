namespace Programa05_06
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
            picImagen = new PictureBox();
            btnCargar = new Button();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            SuspendLayout();
            // 
            // picImagen
            // 
            picImagen.Image = Properties.Resources.itla_logo_full_2020;
            picImagen.Location = new Point(12, 12);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(497, 217);
            picImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagen.TabIndex = 0;
            picImagen.TabStop = false;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(754, 35);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(94, 29);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 497);
            Controls.Add(btnCargar);
            Controls.Add(picImagen);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picImagen;
        private Button btnCargar;
    }
}