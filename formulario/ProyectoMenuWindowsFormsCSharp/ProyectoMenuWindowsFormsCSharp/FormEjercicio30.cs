// Ejercicio 30 - Promedio de dos notas
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio30 : Form
    {
        public FormEjercicio30()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNota1.Text, out double nota1))
            {
                MessageBox.Show("Ingresa un numero valido en la primera nota");
                return;
            }
            if (!double.TryParse(txtNota2.Text, out double nota2))
            {
                MessageBox.Show("Ingresa un numero valido en la segunda nota");
                return;
            }

            double promedio = (nota1 + nota2) / 2;

            if (nota1 >= 0 && nota1 <= 20 && nota2 >= 0 && nota2 <= 20)
            {
                if (promedio >= 10.5 && promedio <= 20)
                    lblResultado.Text = "Promedio: " + promedio + "\nAprobado";
                else
                    lblResultado.Text = "Promedio: " + promedio + "\nDesaprobado";
            }
            else
            {
                lblResultado.Text = "Las notas deben estar en la escala del 0 al 20";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota1.Clear(); txtNota2.Clear();
            lblResultado.Text = "";
            txtNota1.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
