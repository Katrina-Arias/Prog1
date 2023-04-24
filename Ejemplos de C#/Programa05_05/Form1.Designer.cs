namespace Proyecto05_05
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
            lstFrutas = new ListBox();
            txtFruta = new TextBox();
            btnAdicionar = new Button();
            lblFruta = new Label();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lstFrutas
            // 
            lstFrutas.FormattingEnabled = true;
            lstFrutas.ItemHeight = 20;
            lstFrutas.Items.AddRange(new object[] { "Manzana", "Aguacate", "Pera" });
            lstFrutas.Location = new Point(81, 121);
            lstFrutas.Name = "lstFrutas";
            lstFrutas.Size = new Size(150, 104);
            lstFrutas.TabIndex = 0;
            lstFrutas.SelectedIndexChanged += lstFrutas_SelectedIndexChanged;
            // 
            // txtFruta
            // 
            txtFruta.Location = new Point(33, 36);
            txtFruta.Name = "txtFruta";
            txtFruta.Size = new Size(125, 27);
            txtFruta.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(240, 36);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lblFruta
            // 
            lblFruta.AutoSize = true;
            lblFruta.Location = new Point(81, 82);
            lblFruta.Name = "lblFruta";
            lblFruta.Size = new Size(50, 20);
            lblFruta.TabIndex = 3;
            lblFruta.Text = "label1";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(240, 78);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 434);
            Controls.Add(btnEliminar);
            Controls.Add(lblFruta);
            Controls.Add(btnAdicionar);
            Controls.Add(txtFruta);
            Controls.Add(lstFrutas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstFrutas;
        private TextBox txtFruta;
        private Button btnAdicionar;
        private Label lblFruta;
        private Button btnEliminar;
    }
}