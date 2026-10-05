namespace FarmaciaApp
{
    public class FrmInventario : Form
    {
        private readonly FarmaciaDbContext _ctx = new();
        private DataGridView dgv;
        private TextBox txtNombre, txtLab, txtPres, txtStock, txtPrecio, txtFecha;
        private Button btnGuardar, btnEliminar, btnLimpiar;
        private int _idSel = 0;

        public FrmInventario()
        {
            this.Text = "Inventario de Medicamentos - FarmaciaApp";
            this.Size = new System.Drawing.Size(800, 580);
            BuildUI();
            CargarDatos();
        }

        private void BuildUI()
        {
            var pnl = new Panel { Location = new System.Drawing.Point(10, 10), Size = new System.Drawing.Size(400, 280) };

            void Row(string lbl, out TextBox t, int y)
            {
                pnl.Controls.Add(new Label { Text = lbl, Location = new System.Drawing.Point(0, y), AutoSize = true });
                t = new TextBox { Location = new System.Drawing.Point(110, y - 3), Width = 270 };
                pnl.Controls.Add(t);
            }

            Row("Nombre:", out txtNombre, 10);
            Row("Laboratorio:", out txtLab, 45);
            Row("Presentacion:", out txtPres, 80);
            Row("Stock:", out txtStock, 115);
            Row("Precio Unit.:", out txtPrecio, 150);
            Row("Vencimiento:", out txtFecha, 185);

            btnGuardar = new Button { Text = "Guardar", Location = new System.Drawing.Point(0, 230), Width = 100 };
            btnEliminar = new Button { Text = "Eliminar", Location = new System.Drawing.Point(110, 230), Width = 100 };
            btnLimpiar = new Button { Text = "Limpiar", Location = new System.Drawing.Point(220, 230), Width = 100 };

            btnGuardar.Click += (s, e) => Guardar();
            btnEliminar.Click += (s, e) => Eliminar();
            btnLimpiar.Click += (s, e) => Limpiar();

            pnl.Controls.AddRange(new Control[] { btnGuardar, btnEliminar, btnLimpiar });
            this.Controls.Add(pnl);

            dgv = new DataGridView { Location = new System.Drawing.Point(10, 310), Size = new System.Drawing.Size(760, 220), ReadOnly = true, SelectionMode = DataGridViewSelectionMode.FullRowSelect };
            dgv.SelectionChanged += (s, e) =>
            {
                if (dgv.CurrentRow?.DataBoundItem is Medicamento m)
                {
                    _idSel = m.Id;
                    txtNombre.Text = m.Nombre; txtLab.Text = m.Laboratorio;
                    txtPres.Text = m.Presentacion; txtStock.Text = m.Stock.ToString();
                    txtPrecio.Text = m.PrecioUnitario.ToString(); txtFecha.Text = m.FechaVencimiento.ToString("yyyy-MM-dd");
                }
            };
            this.Controls.Add(dgv);
        }

        private void CargarDatos() => dgv.DataSource = _ctx.Medicamentos.ToList();

        private void Guardar()
        {
            if (_idSel == 0)
            {
                var m = new Medicamento { Nombre = txtNombre.Text, Laboratorio = txtLab.Text, Presentacion = txtPres.Text, Stock = int.Parse(txtStock.Text), PrecioUnitario = decimal.Parse(txtPrecio.Text), FechaVencimiento = DateTime.Parse(txtFecha.Text) };
                _ctx.Medicamentos.Add(m);
            }
            else
            {
                var m = _ctx.Medicamentos.Find(_idSel);
                m.Nombre = txtNombre.Text; m.Laboratorio = txtLab.Text; m.Presentacion = txtPres.Text;
                m.Stock = int.Parse(txtStock.Text); m.PrecioUnitario = decimal.Parse(txtPrecio.Text);
                m.FechaVencimiento = DateTime.Parse(txtFecha.Text);
                _ctx.Medicamentos.Update(m);
            }
            _ctx.SaveChanges();
            MessageBox.Show("Guardado exitosamente.");
            Limpiar(); CargarDatos();
        }

        private void Eliminar()
        {
            if (_idSel == 0) return;
            var m = _ctx.Medicamentos.Find(_idSel);
            if (m != null) { _ctx.Medicamentos.Remove(m); _ctx.SaveChanges(); Limpiar(); CargarDatos(); }
        }

        private void Limpiar() { _idSel = 0; foreach (var t in new TextBox[] { txtNombre, txtLab, txtPres, txtStock, txtPrecio, txtFecha }) t.Text = ""; }
    }
}
