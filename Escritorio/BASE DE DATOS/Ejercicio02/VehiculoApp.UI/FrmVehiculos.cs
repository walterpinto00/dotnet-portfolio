using VehiculoApp.Datos;
using VehiculoApp.Negocio;

namespace VehiculoApp.UI
{
    public class FrmVehiculos : Form
    {
        private readonly VehiculoServicio _servicio = new();
        private DataGridView dgv;
        private TextBox txtPlaca, txtMarca, txtModelo, txtAnio, txtValor;
        private Button btnGuardar, btnEliminar, btnLimpiar;
        private int _idSeleccionado = 0;

        public FrmVehiculos()
        {
            this.Text = "Gestion de Vehiculos";
            this.Size = new System.Drawing.Size(750, 520);
            BuildUI();
            CargarDatos();
        }

        private void BuildUI()
        {
            var panel = new Panel { Location = new System.Drawing.Point(10, 10), Size = new System.Drawing.Size(350, 280) };

            void AddRow(string lbl, out TextBox txt, int y)
            {
                panel.Controls.Add(new Label { Text = lbl, Location = new System.Drawing.Point(0, y), AutoSize = true });
                txt = new TextBox { Location = new System.Drawing.Point(90, y - 3), Width = 230 };
                panel.Controls.Add(txt);
            }

            AddRow("Placa:", out txtPlaca, 10);
            AddRow("Marca:", out txtMarca, 45);
            AddRow("Modelo:", out txtModelo, 80);
            AddRow("Anio:", out txtAnio, 115);
            AddRow("Valor:", out txtValor, 150);

            btnGuardar = new Button { Text = "Guardar", Location = new System.Drawing.Point(0, 195), Width = 90 };
            btnEliminar = new Button { Text = "Eliminar", Location = new System.Drawing.Point(100, 195), Width = 90 };
            btnLimpiar = new Button { Text = "Limpiar", Location = new System.Drawing.Point(200, 195), Width = 90 };

            btnGuardar.Click += (s, e) => Guardar();
            btnEliminar.Click += (s, e) => Eliminar();
            btnLimpiar.Click += (s, e) => Limpiar();
            panel.Controls.AddRange(new Control[] { btnGuardar, btnEliminar, btnLimpiar });
            this.Controls.Add(panel);

            dgv = new DataGridView { Location = new System.Drawing.Point(10, 300), Size = new System.Drawing.Size(710, 180), ReadOnly = true, SelectionMode = DataGridViewSelectionMode.FullRowSelect };
            dgv.SelectionChanged += (s, e) =>
            {
                if (dgv.CurrentRow?.DataBoundItem is Vehiculo v)
                {
                    _idSeleccionado = v.Id;
                    txtPlaca.Text = v.Placa; txtMarca.Text = v.Marca;
                    txtModelo.Text = v.Modelo; txtAnio.Text = v.Anio.ToString();
                    txtValor.Text = v.ValorComercial.ToString();
                }
            };
            this.Controls.Add(dgv);
        }

        private void CargarDatos() => dgv.DataSource = _servicio.Listar();

        private void Guardar()
        {
            var v = new Vehiculo { Id = _idSeleccionado, Placa = txtPlaca.Text, Marca = txtMarca.Text, Modelo = txtModelo.Text, Anio = int.TryParse(txtAnio.Text, out int a) ? a : 0, ValorComercial = decimal.TryParse(txtValor.Text, out decimal val) ? val : 0 };
            bool ok = _idSeleccionado == 0 ? _servicio.Registrar(v) : _servicio.Actualizar(v);
            if (ok) { MessageBox.Show("Guardado exitosamente."); Limpiar(); CargarDatos(); }
            else MessageBox.Show("Verifica la placa obligatoria.");
        }

        private void Eliminar()
        {
            if (_idSeleccionado == 0) return;
            if (MessageBox.Show("Eliminar vehiculo?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { _servicio.Eliminar(_idSeleccionado); Limpiar(); CargarDatos(); }
        }

        private void Limpiar() { _idSeleccionado = 0; foreach (var t in new TextBox[] { txtPlaca, txtMarca, txtModelo, txtAnio, txtValor }) t.Text = ""; }
    }
}
