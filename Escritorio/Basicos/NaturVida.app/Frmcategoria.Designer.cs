namespace NaturVida.app
{
    partial class Frmcategoria
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
            DgvCategoria = new DataGridView();
            label1 = new Label();
            TxtNombre = new TextBox();
            ChkActivo = new CheckBox();
            LblId = new Label();
            BtnGuardar = new Button();
            BtnNuevo = new Button();
            BtnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // DgvCategoria
            // 
            DgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCategoria.Location = new Point(12, 12);
            DgvCategoria.Name = "DgvCategoria";
            DgvCategoria.RowHeadersWidth = 51;
            DgvCategoria.Size = new Size(510, 575);
            DgvCategoria.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(587, 39);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(656, 36);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(186, 27);
            TxtNombre.TabIndex = 2;
            // 
            // ChkActivo
            // 
            ChkActivo.AutoSize = true;
            ChkActivo.Location = new Point(866, 39);
            ChkActivo.Name = "ChkActivo";
            ChkActivo.Size = new Size(73, 24);
            ChkActivo.TabIndex = 3;
            ChkActivo.Text = "Activo";
            ChkActivo.UseVisualStyleBackColor = true;
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.Location = new Point(915, 567);
            LblId.Name = "LblId";
            LblId.Size = new Size(24, 20);
            LblId.TabIndex = 4;
            LblId.Text = "ID";
            LblId.Visible = false;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(587, 166);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(94, 29);
            BtnGuardar.TabIndex = 5;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Location = new Point(587, 236);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(94, 29);
            BtnNuevo.TabIndex = 6;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(587, 310);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(94, 29);
            BtnEliminar.TabIndex = 7;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // Frmcategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 610);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnNuevo);
            Controls.Add(BtnGuardar);
            Controls.Add(LblId);
            Controls.Add(ChkActivo);
            Controls.Add(TxtNombre);
            Controls.Add(label1);
            Controls.Add(DgvCategoria);
            Name = "Frmcategoria";
            Text = "Frmcategoria";
            ((System.ComponentModel.ISupportInitialize)DgvCategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvCategoria;
        private Label label1;
        private TextBox TxtNombre;
        private CheckBox ChkActivo;
        private Label LblId;
        private Button BtnGuardar;
        private Button BtnNuevo;
        private Button BtnEliminar;
    }
}