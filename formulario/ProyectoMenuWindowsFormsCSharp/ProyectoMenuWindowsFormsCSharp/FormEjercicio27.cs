// Ejercicio 27 - Consumos de un restaurant
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio27 : Form
    {
        private double c = 1;
        private double total = 0;

        public FormEjercicio27()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (c > 130)
            {
                MessageBox.Show("Ya se ingresaron los 130 consumos");
                return;
            }
            if (!double.TryParse(txtConsumo.Text, out double consumo))
            {
                MessageBox.Show("Ingresa un numero valido");
                return;
            }

            c = c + 1;
            double descuento = consumo > 130 ? consumo * 0.15 : 0;
            consumo = consumo - descuento;
            total = total + consumo;

            int restantes = 130 - (int)(c - 1);

            if (c <= 130)
            {
                lblEstado.Text = "Faltan " + restantes + " consumos";
            }
            else
            {
                lblResultado.Text = "El total de los consumos es: " + total;
                lblEstado.Text = "Proceso terminado";
                btnAgregar.Enabled = false;
            }

            txtConsumo.Clear();
            txtConsumo.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            c = 1;
            total = 0;
            txtConsumo.Clear();
            lblEstado.Text = "Faltan 130 consumos";
            lblResultado.Text = "";
            btnAgregar.Enabled = true;
            txtConsumo.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
