// Ejercicio 19 - Parte fraccionaria
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio19 : Form
    {
        public FormEjercicio19()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNumero.Text, out double numero))
            {
                MessageBox.Show("Ingresa un numero valido");
                return;
            }

            double pf = Math.Truncate(numero);
            if (numero == pf)
                lblResultado.Text = "No tiene parte fraccionaria";
            else
                lblResultado.Text = "Tiene parte fraccionaria";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            lblResultado.Text = "";
            txtNumero.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
