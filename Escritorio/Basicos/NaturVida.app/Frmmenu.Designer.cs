namespace NaturVida.app
{
    partial class Frmmenu
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
            Panelmenu = new Panel();
            Btnproducto = new Button();
            Btncategoria = new Button();
            label1 = new Label();
            Panelcontenido = new Panel();
            Panelmenu.SuspendLayout();
            SuspendLayout();
            // 
            // Panelmenu
            // 
            Panelmenu.BackColor = SystemColors.ActiveCaptionText;
            Panelmenu.Controls.Add(Btnproducto);
            Panelmenu.Controls.Add(Btncategoria);
            Panelmenu.Controls.Add(label1);
            Panelmenu.Location = new Point(12, 12);
            Panelmenu.Name = "Panelmenu";
            Panelmenu.Size = new Size(292, 685);
            Panelmenu.TabIndex = 0;
            Panelmenu.Paint += panel1_Paint;
            // 
            // Btnproducto
            // 
            Btnproducto.Location = new Point(66, 297);
            Btnproducto.Name = "Btnproducto";
            Btnproducto.Size = new Size(158, 81);
            Btnproducto.TabIndex = 2;
            Btnproducto.Text = "Producto";
            Btnproducto.UseVisualStyleBackColor = true;
            // 
            // Btncategoria
            // 
            Btncategoria.Location = new Point(66, 189);
            Btncategoria.Name = "Btncategoria";
            Btncategoria.Size = new Size(158, 78);
            Btncategoria.TabIndex = 1;
            Btncategoria.Text = "Categoria";
            Btncategoria.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(101, 55);
            label1.Name = "label1";
            label1.Size = new Size(93, 38);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // Panelcontenido
            // 
            Panelcontenido.Location = new Point(325, 12);
            Panelcontenido.Name = "Panelcontenido";
            Panelcontenido.Size = new Size(977, 685);
            Panelcontenido.TabIndex = 1;
            // 
            // Frmmenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 709);
            Controls.Add(Panelcontenido);
            Controls.Add(Panelmenu);
            Name = "Frmmenu";
            Text = "Frmmenu";
            Load += Frmmenu_Load;
            Panelmenu.ResumeLayout(false);
            Panelmenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panelmenu;
        private Button Btnproducto;
        private Button Btncategoria;
        private Label label1;
        private Panel Panelcontenido;
    }
}