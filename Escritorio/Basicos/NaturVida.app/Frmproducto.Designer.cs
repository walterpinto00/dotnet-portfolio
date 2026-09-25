namespace NaturVida.app
{
    partial class Frmproducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DgvProducto = new DataGridView();
            Cbocategoria = new ComboBox();
            Numstock = new NumericUpDown();
            Txtnombre = new TextBox();
            Txtprecio = new TextBox();
            LblId = new Label();
            BtnGuardar = new Button();
            BtnNuevo = new Button();
            BtnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Numstock).BeginInit();
            SuspendLayout();
            // 
            // DgvProducto
            // 
            DgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProducto.Location = new Point(12, 12);
            DgvProducto.Name = "DgvProducto";
            DgvProducto.RowHeadersWidth = 51;
            DgvProducto.Size = new Size(432, 375);
            DgvProducto.TabIndex = 0;
            // 
            // Cbocategoria
            // 
            Cbocategoria.FormattingEnabled = true;
            Cbocategoria.Location = new Point(582, 29);
            Cbocategoria.Name = "Cbocategoria";
            Cbocategoria.Size = new Size(151, 28);
            Cbocategoria.TabIndex = 1;
            Cbocategoria.SelectedIndexChanged += Cbocategoria_SelectedIndexChanged;
            // 
            // Numstock
            // 
            Numstock.Location = new Point(582, 222);
            Numstock.Name = "Numstock";
            Numstock.Size = new Size(151, 27);
            Numstock.TabIndex = 2;
            // 
            // Txtnombre
            // 
            Txtnombre.Location = new Point(582, 92);
            Txtnombre.Name = "Txtnombre";
            Txtnombre.Size = new Size(151, 27);
            Txtnombre.TabIndex = 3;
            // 
            // Txtprecio
            // 
            Txtprecio.Location = new Point(582, 157);
            Txtprecio.Name = "Txtprecio";
            Txtprecio.Size = new Size(151, 27);
            Txtprecio.TabIndex = 4;
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.Location = new Point(797, 484);
            LblId.Name = "LblId";
            LblId.Size = new Size(24, 20);
            LblId.TabIndex = 5;
            LblId.Text = "ID";
            LblId.Visible = false;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(477, 306);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(94, 29);
            BtnGuardar.TabIndex = 6;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click_1;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Location = new Point(592, 306);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(94, 29);
            BtnNuevo.TabIndex = 7;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click_1;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(704, 306);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(94, 29);
            BtnEliminar.TabIndex = 8;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(477, 29);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 9;
            label1.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(477, 92);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 10;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(477, 157);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 11;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(477, 222);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 12;
            label4.Text = "Stock";
            // 
            // Frmproducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 513);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnNuevo);
            Controls.Add(BtnGuardar);
            Controls.Add(LblId);
            Controls.Add(Txtprecio);
            Controls.Add(Txtnombre);
            Controls.Add(Numstock);
            Controls.Add(Cbocategoria);
            Controls.Add(DgvProducto);
            Name = "Frmproducto";
            Text = "Frmproducto";
            Load += Frmproducto_Load_1;
            ((System.ComponentModel.ISupportInitialize)DgvProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)Numstock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvProducto;
        private ComboBox Cbocategoria;
        private NumericUpDown Numstock;
        private TextBox Txtnombre;
        private TextBox Txtprecio;
        private Label LblId;
        private Button BtnGuardar;
        private Button BtnNuevo;
        private Button BtnEliminar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}