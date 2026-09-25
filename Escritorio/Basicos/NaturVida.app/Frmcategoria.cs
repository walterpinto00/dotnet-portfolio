using NaturVida.app.Logic;
using NaturVida.app.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NaturVida.app
{
    public partial class Frmcategoria : Form
    {
        private readonly CategoriaBLL bll = new();
        public Frmcategoria()
        {
            InitializeComponent();
            BtnGuardar.Click += BtnGuardar_Click;
            BtnEliminar.Click += BtnEliminar_Click;
            BtnNuevo.Click += BtnNuevo_Click;
            DgvCategoria.CellClick += DgvCategoria_CellClick;
        }
        private void Frmcategoria_Load(object s, EventArgs e) => Cargar();

        private void Cargar()
        {
            DgvCategoria.DataSource = bll.Listar();
            DgvCategoria.Columns["Id"].Visible = false; // Ocultar ID en grilla
            Limpiar();
        }

        private void DgvCategoria_CellClick(object? s, DataGridViewCellEventArgs e)
        {
            if (DgvCategoria.CurrentRow == null) return;

            var cat = (Categoria)DgvCategoria.CurrentRow.DataBoundItem;
            LblId.Text = cat.Id.ToString();
            TxtNombre.Text = cat.Nombre;
            ChkActivo.Checked = cat.Activo;
        }

        private void BtnGuardar_Click(object? s, EventArgs e)
        {
            var cat = new Categoria
            {
                Id = int.TryParse(LblId.Text, out int id) ? id : 0,
                Nombre = TxtNombre.Text.Trim(),
                Activo = ChkActivo.Checked
            };

            string msg = bll.Guardar(cat);
            MessageBox.Show(msg, "Resultado");
            Cargar();
        }

        private void BtnEliminar_Click(object? s, EventArgs e)
        {
            if (LblId.Text == "") return;

            var res = MessageBox.Show("¿Eliminar categoría?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string msg = bll.Eliminar(int.Parse(LblId.Text));
                MessageBox.Show(msg);
                Cargar();
            }
        }

        private void BtnNuevo_Click(object? s, EventArgs e) => Limpiar();

        private void Limpiar()
        {
            TxtNombre.Clear();
            ChkActivo.Checked = true;
            LblId.Text = string.Empty;
            TxtNombre.Focus();

        }
    }
}
