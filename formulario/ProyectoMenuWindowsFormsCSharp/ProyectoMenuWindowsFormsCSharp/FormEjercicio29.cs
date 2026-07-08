// Ejercicio 29 - Caja de la compania Barner
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio29 : Form
    {
        private double caja = 371;
        private double totalegresos = 0;
        private double restocaja = 0;
        private double cont = 0;

        public FormEjercicio29()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtEgreso.Text, out double egreso))
            {
                MessageBox.Show("Ingresa un numero valido");
                return;
            }

            cont = cont + 1;
            totalegresos = totalegresos + egreso;
            restocaja = caja - totalegresos;

            if (egreso != -1)
            {
                lstResultados.Items.Add("Egreso " + cont + ": " + egreso);
                txtEgreso.Clear();
                txtEgreso.Focus();
            }
            else
            {
                lstResultados.Items.Add("----------------------------");
                lstResultados.Items.Add("Total de egresos: " + (totalegresos + 1));
                lstResultados.Items.Add("Sobrante en caja: " + (restocaja - 1));
                btnAgregar.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            caja = 371;
            totalegresos = 0;
            restocaja = 0;
            cont = 0;
            txtEgreso.Clear();
            lstResultados.Items.Clear();
            btnAgregar.Enabled = true;
            txtEgreso.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
