namespace Natur.Vida.app.UI;
public partial class frmMenu : Form
{
    public frmMenu()
    {
        InitializeComponent();

        btnCategorias.Click += (s, e) => AbrirFormulario(new frmCategorias());
        btnProductos.Click += (s, e) => AbrirFormulario(new frmProductos());
    }

    private void AbrirFormulario(Form hijo)
    {
        // 1. Limpiar contenido anterior
        panelContenido.Controls.Clear();

        // 2. Configurar el formulario para comportarse como control
        hijo.TopLevel = false;              // No es ventana independiente
        hijo.FormBorderStyle = FormBorderStyle.None; // Sin bordes
        hijo.Dock = DockStyle.Fill;          // Ocupa todo el panel

        // 3. Inyectar y mostrar
        panelContenido.Controls.Add(hijo);
        hijo.Show();
    }
}
