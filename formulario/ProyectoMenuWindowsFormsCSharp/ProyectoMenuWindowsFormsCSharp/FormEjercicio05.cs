// Ejercicio 05 - Minutos a dias, horas y minutos
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio05 : Form
    {
        public FormEjercicio05()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTiempo.Text, out int tiempo))
            {
                MessageBox.Show("Ingresa un numero entero valido");
                return;
            }

            if (tiempo >= 0)
            {
                int dias = (tiempo - (tiempo % 60)) / 1440;
                int x = tiempo % 1440;
                int horas = (x - (x % 60)) / 60;
                int minutos = x % 60;
                lblResultado.Text = "Equivale a " + dias + " dias con " + horas + " horas y " + minutos + " minutos";
            }
            else
            {
                lblResultado.Text = "El tiempo no puede ser negativo";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTiempo.Clear();
            lblResultado.Text = "";
            txtTiempo.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
