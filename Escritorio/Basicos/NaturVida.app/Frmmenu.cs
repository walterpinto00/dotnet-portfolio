using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NaturVida.app
{
    public partial class Frmmenu : Form
    {
        public Frmmenu()
        {
            InitializeComponent();
            Btncategoria.Click += (s, e) => AbrirFormulario(new Frmcategoria());
            Btnproducto.Click += (s, e) => AbrirFormulario(new Frmproducto());
        }

        private void AbrirFormulario(Form hijo)
        {
            // 1. Limpiar contenido anterior
            Panelcontenido.Controls.Clear();

            // 2. Configurar el formulario para comportarse como control
            hijo.TopLevel = false;              // No es ventana independiente
            hijo.FormBorderStyle = FormBorderStyle.None; // Sin bordes
            hijo.Dock = DockStyle.Fill;           // Ocupa todo el panel

            // 3. Inyectar y mostrar
            Panelcontenido.Controls.Add(hijo);
            hijo.Show();
        }
    


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frmmenu_Load(object sender, EventArgs e)
        {

        }
    }
}
