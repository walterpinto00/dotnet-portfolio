using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_registro_de_evaluaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Capturar valores
            string alumno = txtAlumno.Text;
            int E1 = int.Parse(txtEva1.Text);
            int E2 = int.Parse(txtEva2.Text);
            int E3 = int.Parse(txtEva3.Text);
            int E4 = int.Parse(txtEva4.Text);

            //Menor nota
            int menor = 0;

            if (E1 < E2) { menor = E1; } else { menor = E2; }
            if (E3 < menor) { menor = E3; }
            if (E4 < menor) { menor = E4; }

            //Promedio
            int promedio = (E1 + E2 + E3 + E4 - menor) / 3;

            //Condicion
            string condicion = promedio >= 70 ? "aprobado" : "desaprobado";

            //Imprimir resultados
            ListViewItem fila = new ListViewItem(alumno);
            fila.SubItems.Add(E1.ToString());
            fila.SubItems.Add(E2.ToString());
            fila.SubItems.Add(E3.ToString());
            fila.SubItems.Add(E4.ToString());
            fila.SubItems.Add(menor.ToString());
            fila.SubItems.Add(promedio.ToString());
            fila.SubItems.Add(condicion);
            lvRegistro.Items.Add(fila);

        }

        private void txtE1(object sender, EventArgs e)
        {

        }

        private void txtE2(object sender, EventArgs e)
        {

        }

        private void txtE3(object sender, EventArgs e)
        {

        }

        private void txtE4(object sender, EventArgs e)
        {

        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAlumno_Validated(object sender, EventArgs e)
        {
            if (txtAlumno.Text.Trim().Length < 5)
            {

                controlErrores.SetError(txtAlumno, "El nombre del alumno debe tener al menos 5 caracteres");
            }
            else
            {

                controlErrores.Clear();

            }
        }

        private void EpErrors(object sender, EventArgs e)
        {

        }

        private void txtEva2_TextChanged(object sender, EventArgs e)
        {
            if (txtEva2.Text.Trim().Length < 5)
            {

                controlErrores.SetError(txtAlumno, "ingrese a nota");
            }
            else
            {


                controlErrores.Clear();

            }
        }

        private void txtEva1_TextChanged(object sender, EventArgs e)
        {
            if (txtEva1.Text.Trim().Length < 5)
            {

                controlErrores.SetError(txtAlumno, "El nombre del alumno debe tener al menos 5 caracteres");
            }
            else
            {


                controlErrores.Clear();

            }
        }

        private void txtEva3_TextChanged(object sender, EventArgs e)
        {
            if (txtEva3.Text.Trim().Length < 5)
            {

                controlErrores.SetError(txtAlumno, "El nombre del alumno debe tener al menos 5 caracteres");
            }
            else
            {


                controlErrores.Clear();

            }
        }

        private void txtEva4_TextChanged(object sender, EventArgs e)
        {
            if (txtEva4.Text.Trim().Length < 5)
            {

                controlErrores.SetError(txtAlumno, "El nombre del alumno debe tener al menos 5 caracteres");
            }
            else
            {


                controlErrores.Clear();

            }
        }

    } 
}