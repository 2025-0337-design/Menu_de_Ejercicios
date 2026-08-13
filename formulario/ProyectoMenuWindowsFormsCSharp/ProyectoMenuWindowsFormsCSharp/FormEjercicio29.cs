// Ejercicio 29 - Caja de la compania Barner
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio29 : Form
    {
        private double caja = 371;
        private double totalegresos = 0;
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

            cont++;
            totalegresos += egreso;
            double restocaja = caja - totalegresos;

            if (egreso != -1)
            {
                lstResultados.Items.Add("Egreso " + cont + ": " + egreso
                                      + "   |   Saldo: " + Math.Round(restocaja, 2));
                lblSaldo.Text = "Saldo en caja: " + Math.Round(restocaja, 2);
                txtEgreso.Clear();
                txtEgreso.Focus();
            }
            else
            {
                double totalReal  = Math.Round(totalegresos + 1, 2);
                double saldoReal  = Math.Round(restocaja - 1, 2);
                lstResultados.Items.Add("----------------------------");
                lstResultados.Items.Add("Total egresos: " + totalReal);
                lstResultados.Items.Add("Sobrante en caja: " + saldoReal);
                lblSaldo.Text = "Sobrante final en caja: " + saldoReal;
                btnAgregar.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            caja = 371;
            totalegresos = 0;
            cont = 0;
            txtEgreso.Clear();
            lstResultados.Items.Clear();
            lblSaldo.Text = "Saldo en caja: 371";
            btnAgregar.Enabled = true;
            txtEgreso.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e) { this.Close(); }
        private void btnSalir_Click(object sender, EventArgs e)  { Application.Exit(); }
    }
}
