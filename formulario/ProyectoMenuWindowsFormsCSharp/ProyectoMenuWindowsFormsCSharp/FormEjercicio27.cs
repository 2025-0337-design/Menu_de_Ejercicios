// Ejercicio 27 - Consumos de un restaurant
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio27 : Form
    {
        private const int TOTAL_CONSUMOS = 10;
        private int c = 0;
        private double total = 0;

        public FormEjercicio27()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtConsumo.Text, out double consumo))
            {
                MessageBox.Show("Ingresa un numero valido");
                return;
            }

            double descuento = consumo > 130 ? consumo * 0.15 : 0;
            double consumoFinal = consumo - descuento;
            total = Math.Round(total + consumoFinal, 2);
            c++;

            string lineaDesc = descuento > 0 ? "  (con descuento: " + Math.Round(consumoFinal, 2) + ")" : "";
            lblAcumulado.Text = "Total acumulado: " + total + lineaDesc;

            if (c < TOTAL_CONSUMOS)
            {
                lblEstado.Text = "Consumo " + (c + 1) + " de " + TOTAL_CONSUMOS;
            }
            else
            {
                lblResultado.Text = "Total final de los " + TOTAL_CONSUMOS + " consumos: " + total;
                lblEstado.Text = "Proceso terminado";
                btnAgregar.Enabled = false;
            }

            txtConsumo.Clear();
            txtConsumo.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            c = 0;
            total = 0;
            txtConsumo.Clear();
            lblEstado.Text = "Consumo 1 de " + TOTAL_CONSUMOS;
            lblAcumulado.Text = "Total acumulado: 0";
            lblResultado.Text = "";
            btnAgregar.Enabled = true;
            txtConsumo.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e) { this.Close(); }
        private void btnSalir_Click(object sender, EventArgs e)  { Application.Exit(); }
    }
}
