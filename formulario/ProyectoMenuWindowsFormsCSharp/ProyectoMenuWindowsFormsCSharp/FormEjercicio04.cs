// Ejercicio 04 - Segundos a minutos
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio04 : Form
    {
        public FormEjercicio04()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSegundos.Text, out int tiemposegundos))
            {
                MessageBox.Show("Ingresa un numero entero valido");
                return;
            }

            int minutos, segundosrestantes;

            if (tiemposegundos < 60 && tiemposegundos > 0)
            {
                segundosrestantes = 60 - tiemposegundos;
                lblResultado.Text = "Le faltan " + segundosrestantes + " segundos para convertirse en minuto";
            }
            else if (tiemposegundos >= 60)
            {
                minutos = (tiemposegundos - (tiemposegundos % 60)) / 60;
                segundosrestantes = tiemposegundos % 60;
                lblResultado.Text = "Equivale a " + minutos + " minutos y le faltan " + segundosrestantes + " segundos para convertirse en minuto";
            }
            else
            {
                lblResultado.Text = "La cantidad de segundos debe ser un numero positivo";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSegundos.Clear();
            lblResultado.Text = "";
            txtSegundos.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
