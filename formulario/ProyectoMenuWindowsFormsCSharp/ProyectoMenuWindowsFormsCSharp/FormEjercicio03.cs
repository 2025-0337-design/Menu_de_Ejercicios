// Ejercicio 03 - Descuento por monto
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio03 : Form
    {
        public FormEjercicio03()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtMonto.Text, out double monto))
            {
                MessageBox.Show("Ingresa un numero valido en monto");
                return;
            }

            double descuento;

            if (monto > 100)
            {
                descuento = monto * 0.1;
                lblResultado.Text = "El monto " + monto + " tiene un descuento de " + descuento;
            }
            else if (monto <= 100 && monto > 0)
            {
                descuento = monto * 0.2;
                lblResultado.Text = "El monto " + monto + " tiene un descuento de " + descuento;
            }
            else
            {
                lblResultado.Text = "El monto no puede ser negativo";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMonto.Clear();
            lblResultado.Text = "";
            txtMonto.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
