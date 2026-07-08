// Ejercicio 14 - Media de 100 numeros
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio14 : Form
    {
        private int contador = 0;
        private double suma = 0;

        public FormEjercicio14()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (contador >= 100)
            {
                MessageBox.Show("Ya se ingresaron los 100 numeros");
                return;
            }
            if (!double.TryParse(txtNumero.Text, out double numero))
            {
                MessageBox.Show("Ingresa un numero valido");
                return;
            }

            suma = suma + numero;
            contador++;
            int restantes = 100 - contador;

            if (restantes > 0)
                lblEstado.Text = "Faltan " + restantes + " numeros";
            else
            {
                double media = Math.Round(suma / 100, 2);
                lblResultado.Text = "La media de los 100 numeros es: " + media;
                lblEstado.Text = "Proceso terminado";
                btnAgregar.Enabled = false;
            }

            txtNumero.Clear();
            txtNumero.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            contador = 0;
            suma = 0;
            txtNumero.Clear();
            lblEstado.Text = "Faltan 100 numeros";
            lblResultado.Text = "";
            btnAgregar.Enabled = true;
            txtNumero.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
