namespace Natur.Vida.app.UI
{
    partial class frmMenu
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
            panelContenido = new Panel();
            panelMenu = new Panel();
            btnProductos = new Button();
            btnCategorias = new Button();
            lblTitulo = new Label();
            panelMenu.SuspendLayout();
            SuspendLayout();
            //
            // panelContenido
            //
            panelContenido.BackColor = Color.FromArgb(243, 244, 246);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(220, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(580, 450);
            panelContenido.TabIndex = 0;
            //
            // panelMenu
            //
            panelMenu.BackColor = Color.FromArgb(15, 23, 42);
            panelMenu.Controls.Add(btnProductos);
            panelMenu.Controls.Add(btnCategorias);
            panelMenu.Controls.Add(lblTitulo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Padding = new Padding(10);
            panelMenu.Size = new Size(220, 450);
            panelMenu.TabIndex = 1;
            //
            // btnProductos
            //
            btnProductos.BackColor = Color.FromArgb(30, 41, 59);
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.Font = new Font("Segoe UI", 11F);
            btnProductos.ForeColor = Color.White;
            btnProductos.Height = 45;
            btnProductos.Location = new Point(10, 105);
            btnProductos.Margin = new Padding(5);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(200, 45);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleCenter;
            btnProductos.UseVisualStyleBackColor = false;
            //
            // btnCategorias
            //
            btnCategorias.BackColor = Color.FromArgb(30, 41, 59);
            btnCategorias.Dock = DockStyle.Top;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.Font = new Font("Segoe UI", 11F);
            btnCategorias.ForeColor = Color.White;
            btnCategorias.Height = 45;
            btnCategorias.Location = new Point(10, 60);
            btnCategorias.Margin = new Padding(5);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(200, 45);
            btnCategorias.TabIndex = 1;
            btnCategorias.Text = "Categorías";
            btnCategorias.TextAlign = ContentAlignment.MiddleCenter;
            btnCategorias.UseVisualStyleBackColor = false;
            //
            // lblTitulo
            //
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Height = 60;
            lblTitulo.Location = new Point(10, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(200, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "NaturVida";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // frmMenu
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContenido);
            Controls.Add(panelMenu);
            Name = "frmMenu";
            Text = "NaturVida";
            WindowState = FormWindowState.Maximized;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenido;
        private Panel panelMenu;
        private Button btnProductos;
        private Button btnCategorias;
        private Label lblTitulo;
    }
}
