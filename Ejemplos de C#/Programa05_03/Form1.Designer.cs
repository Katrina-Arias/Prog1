namespace Programa05_03
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
            dtgvProductos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblInformacion = new Label();
            btnAdicionar = new Button();
            btnBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dtgvProductos
            // 
            dtgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProductos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Precio });
            dtgvProductos.Location = new Point(6, 237);
            dtgvProductos.Name = "dtgvProductos";
            dtgvProductos.RowHeadersWidth = 51;
            dtgvProductos.RowTemplate.Height = 29;
            dtgvProductos.Size = new Size(475, 185);
            dtgvProductos.TabIndex = 0;
            dtgvProductos.CellClick += dtgvProductos_CellClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo Producto";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre Producto ";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio Producto";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 125;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(6, 21);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(106, 18);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 2;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(106, 114);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 4;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(6, 117);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(106, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 63);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Location = new Point(12, 188);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(50, 20);
            lblInformacion.TabIndex = 7;
            lblInformacion.Text = "label1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(297, 17);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 8;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(297, 63);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 9;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 427);
            Controls.Add(btnBorrar);
            Controls.Add(btnAdicionar);
            Controls.Add(lblInformacion);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(dtgvProductos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvProductos;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblInformacion;
        private Button btnAdicionar;
        private Button btnBorrar;
    }
}