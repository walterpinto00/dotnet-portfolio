using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class FrmpagoEmpleados : Form
    {
        public FrmpagoEmpleados()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnlLmpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var rta = MessageBox.Show("¿Desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rta == DialogResult.Yes)
            {
                this.Close();
            }
                        }
        
        
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
        //Recuperar informacion
        int horas = Convert.ToInt32(txtHoras.Text);
        double costoHoras = Convert.ToDouble(txtCosto.Text);
            //Realizar calculos
            double salaiobasico = horas * costoHoras;
            double bonificacion = salaiobasico * 0.20;
            double bruto = salaiobasico + bonificacion;
            double descuento = bruto * 0.12;
            double neto = bruto - descuento;

            //imprimimos resultados
            lblMontoBruto.Text = bruto.ToString("C");
            lblmontoDescuento.Text = descuento.ToString("C");
            lblmontoNeto.Text = neto.ToString("C");
        }

        private void txtHoras_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
