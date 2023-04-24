namespace Programa05_07
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            imglFotos = new ImageList(components);
            lblFoto = new Label();
            btnCambio = new Button();
            pctbImagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctbImagen).BeginInit();
            SuspendLayout();
            // 
            // imglFotos
            // 
            imglFotos.ColorDepth = ColorDepth.Depth32Bit;
            imglFotos.ImageStream = (ImageListStreamer)resources.GetObject("imglFotos.ImageStream");
            imglFotos.TransparentColor = Color.Transparent;
            imglFotos.Images.SetKeyName(0, "WhatsApp Image 2023-04-09 at 7.38.00 PM (1).jpeg");
            imglFotos.Images.SetKeyName(1, "Bitmap1.bmp");
            // 
            // lblFoto
            // 
            lblFoto.ImageIndex = 1;
            lblFoto.ImageList = imglFotos;
            lblFoto.Location = new Point(12, 31);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(141, 118);
            lblFoto.TabIndex = 0;
            // 
            // btnCambio
            // 
            btnCambio.Location = new Point(18, 162);
            btnCambio.Name = "btnCambio";
            btnCambio.Size = new Size(135, 29);
            btnCambio.TabIndex = 1;
            btnCambio.Text = "Cambiar imagen";
            btnCambio.UseVisualStyleBackColor = true;
            btnCambio.Click += btnCambio_Click;
            // 
            // pctbImagen
            // 
            pctbImagen.Location = new Point(223, 31);
            pctbImagen.Name = "pctbImagen";
            pctbImagen.Size = new Size(100, 100);
            pctbImagen.TabIndex = 2;
            pctbImagen.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 317);
            Controls.Add(pctbImagen);
            Controls.Add(btnCambio);
            Controls.Add(lblFoto);
            Name = "Form1";
            Text = "Form1";
            Load += btnCambio_Click;
            ((System.ComponentModel.ISupportInitialize)pctbImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imglFotos;
        private Label lblFoto;
        private Button btnCambio;
        private PictureBox pctbImagen;
    }
}