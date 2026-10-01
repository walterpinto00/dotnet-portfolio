using ClienteApp.Datos;
using ClienteApp.Negocio;

namespace ClienteApp.UI
{
    public class FrmClientes : Form
    {
        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=ClienteDB;Trusted_Connection=True;";
        private readonly ClienteServicio _servicio;
        private DataGridView dgvClientes;
        private TextBox txtNombre, txtApellido, txtTelefono, txtEmail;
        private Button btnGuardar, btnEliminar, btnLimpiar;
        private int _idSeleccionado = 0;

        public FrmClientes()
        {
            _servicio = new ClienteServicio(new ClienteRepositorio(ConnectionString));
            InitializeComponent();
            CargarClientes();
        }

        private void InitializeComponent()
        {
            this.Text = "Gestión de Clientes";
            this.Size = new System.Drawing.Size(700, 500);

            var pnlForm = new Panel { Location = new System.Drawing.Point(10, 10), Size = new System.Drawing.Size(300, 300) };
            
            void AddField(string label, out TextBox txt, int y)
            {
                pnlForm.Controls.Add(new Label { Text = label, Location = new System.Drawing.Point(0, y), AutoSize = true });
                txt = new TextBox { Location = new System.Drawing.Point(80, y - 3), Width = 200 };
                pnlForm.Controls.Add(txt);
            }

            AddField("Nombre:", out txtNombre, 10);
            AddField("Apellido:", out txtApellido, 45);
            AddField("Teléfono:", out txtTelefono, 80);
            AddField("Email:", out txtEmail, 115);

            btnGuardar = new Button { Text = "Guardar", Location = new System.Drawing.Point(0, 160), Width = 90 };
            btnEliminar = new Button { Text = "Eliminar", Location = new System.Drawing.Point(100, 160), Width = 90 };
            btnLimpiar = new Button { Text = "Limpiar", Location = new System.Drawing.Point(200, 160), Width = 90 };

            btnGuardar.Click += BtnGuardar_Click;
            btnEliminar.Click += BtnEliminar_Click;
            btnLimpiar.Click += (s, e) => LimpiarFormulario();

            pnlForm.Controls.AddRange(new Control[] { btnGuardar, btnEliminar, btnLimpiar });
            this.Controls.Add(pnlForm);

            dgvClientes = new DataGridView
            {
                Location = new System.Drawing.Point(10, 320),
                Size = new System.Drawing.Size(660, 130),
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            dgvClientes.SelectionChanged += DgvClientes_SelectionChanged;
            this.Controls.Add(dgvClientes);
        }

        private void CargarClientes()
        {
            dgvClientes.DataSource = _servicio.ObtenerClientes();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente
            {
                Id = _idSeleccionado,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text
            };

            bool resultado = _idSeleccionado == 0
                ? _servicio.RegistrarCliente(cliente)
                : _servicio.ActualizarCliente(cliente);

            if (resultado)
            {
                MessageBox.Show("Operación exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarClientes();
            }
            else
                MessageBox.Show("Verifica los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0) return;
            if (MessageBox.Show("¿Eliminar cliente?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _servicio.EliminarCliente(_idSeleccionado);
                LimpiarFormulario();
                CargarClientes();
            }
        }

        private void DgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow?.DataBoundItem is Cliente c)
            {
                _idSeleccionado = c.Id;
                txtNombre.Text = c.Nombre;
                txtApellido.Text = c.Apellido;
                txtTelefono.Text = c.Telefono;
                txtEmail.Text = c.Email;
            }
        }

        private void LimpiarFormulario()
        {
            _idSeleccionado = 0;
            txtNombre.Text = txtApellido.Text = txtTelefono.Text = txtEmail.Text = "";
        }
    }
}
