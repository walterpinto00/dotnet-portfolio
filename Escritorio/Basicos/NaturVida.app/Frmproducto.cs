using NaturVida.app.Data;
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
    public partial class Frmproducto : Form
    {
        private readonly CategoriaBLL catBll = new();
        private readonly ProductoBLL prodBll = new();
        public Frmproducto()
        {
            InitializeComponent();
            DgvProducto.CellClick += DgvProducto_CellClick;
        }

        private void Frmproducto_Load(object s, EventArgs e)
        {
            CargarCategorias();
            CargarGrilla();
        }

        private void CargarCategorias()
        {
            // 1. Cargar ComboBox de categorías
            var categorias = catBll.Listar();
            Cbocategoria.DataSource = categorias;
            Cbocategoria.DisplayMember = "Nombre";   // Lo que ve el usuario
            Cbocategoria.ValueMember = "Id";         // El valor oculto (ID)
        }

        private void CargarGrilla()
        {
            DgvProducto.DataSource = prodBll.Listar();
            DgvProducto.Columns["Id"].Visible = false;
            DgvProducto.Columns["CategoriaId"].Visible = false;
            DgvProducto.Columns["Categoria"].Visible = false;
            Limpiar();
        }

        // 🔘 Evento al hacer clic en una fila del DataGridView
        private void DgvProducto_CellClick(object? s, DataGridViewCellEventArgs e)
        {
            if (DgvProducto.CurrentRow == null) return;

            var prod = (Producto)DgvProducto.CurrentRow.DataBoundItem;
            LblId.Text = prod.Id.ToString();
            Txtnombre.Text = prod.Nombre;
            Txtprecio.Text = prod.Precio.ToString();
            Numstock.Value = prod.Stock;

            // Seleccionar la categoría correcta en el ComboBox
            Cbocategoria.SelectedValue = prod.CategoriaId;
        }

        private void BtnGuardar_Click_1(object s, EventArgs e)
        {
            // 2. Obtener ID seleccionado del ComboBox
            int idCatSeleccionada = Cbocategoria.SelectedValue != null
                ? (int)Cbocategoria.SelectedValue : 0;

            var prod = new Producto
            {
                Id = int.TryParse(LblId.Text, out int id) ? id : 0,
                Nombre = Txtnombre.Text,
                Precio = Txtprecio.Text != "" ? decimal.Parse(Txtprecio.Text) : 0,
                Stock = (int)Numstock.Value,
                CategoriaId = idCatSeleccionada
            };

            string msg = prod.Id > 0 ? prodBll.Guardar(prod) : prodBll.Guardar(prod);
            MessageBox.Show(msg);
            CargarGrilla();
        }

        private void BtnEliminar_Click_1(object s, EventArgs e)
        {
            if (LblId.Text == "" || LblId.Text == "0") return;

            var res = MessageBox.Show("¿Eliminar producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                prodBll.Eliminar(int.Parse(LblId.Text));
                CargarGrilla();
            }
        }

        private void BtnNuevo_Click_1(object s, EventArgs e) => Limpiar();

        private void Limpiar()
        {
            LblId.Text = "";
            Txtnombre.Clear();
            Txtprecio.Clear();
            Numstock.Value = 0;
            // Resetear ComboBox al primer elemento
            if (Cbocategoria.Items.Count > 0) Cbocategoria.SelectedIndex = 0;
            DgvProducto.ClearSelection();
        }

        private void Frmproducto_Load_1(object sender, EventArgs e)
        {

        }

        private void Cbocategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
