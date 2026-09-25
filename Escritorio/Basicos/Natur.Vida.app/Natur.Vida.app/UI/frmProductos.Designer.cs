namespace Natur.Vida.app.UI
{
    partial class frmProductos
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
            dgvProductos = new DataGridView();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            lblStock = new Label();
            numStock = new NumericUpDown();
            lblCategoria = new Label();
            cboCategoria = new ComboBox();
            lblId = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Dock = DockStyle.Top;
            dgvProductos.Location = new Point(0, 0);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(800, 300);
            dgvProductos.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(22, 320);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(100, 317);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(180, 27);
            txtNombre.TabIndex = 2;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(300, 320);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 20);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(360, 317);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 27);
            txtPrecio.TabIndex = 4;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(480, 320);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(48, 20);
            lblStock.TabIndex = 5;
            lblStock.Text = "Stock:";
            // 
            // numStock
            // 
            numStock.Location = new Point(535, 317);
            numStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(80, 27);
            numStock.TabIndex = 6;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(22, 360);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 20);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoría:";
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.Location = new Point(100, 357);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(200, 28);
            cboCategoria.TabIndex = 8;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(758, 461);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 20);
            lblId.TabIndex = 9;
            lblId.Text = "0";
            lblId.Visible = false;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(22, 430);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(120, 35);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "🆕 Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(160, 430);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 35);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(298, 430);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 35);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "🗑️ Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 490);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(lblId);
            Controls.Add(cboCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(numStock);
            Controls.Add(lblStock);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(dgvProductos);
            Name = "frmProductos";
            Text = "Productos";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblStock;
        private NumericUpDown numStock;
        private Label lblCategoria;
        private ComboBox cboCategoria;
        private Label lblId;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}
