// Ejercicio 12 - Clasificar 50 numeros
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio12 : Form
    {
        private int contador = 0;
        private int pares = 0;
        private int impares = 0;
        private int positivos = 0;
        private int negativos = 0;

        public FormEjercicio12()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (contador >= 50)
            {
                MessageBox.Show("Ya se ingresaron los 50 numeros");
                return;
            }
            if (!int.TryParse(txtNumero.Text, out int numero))
            {
                MessageBox.Show("Ingresa un numero entero valido");
                return;
            }

            contador++;

            if (numero % 2 == 0) pares++;
            else impares++;

            if (numero > 0) positivos++;
            else negativos++;

            int restantes = 50 - contador;

            if (restantes > 0)
            {
                lblEstado.Text = "Faltan " + restantes + " numeros";
                lstResultados.Items.Add(contador + ". numero: " + numero);
            }
            else
            {
                lblEstado.Text = "Proceso terminado";
                lstResultados.Items.Add(contador + ". numero: " + numero);
                lstResultados.Items.Add("------------------------------");
                lstResultados.Items.Add("Pares: " + pares);
                lstResultados.Items.Add("Impares: " + impares);
                lstResultados.Items.Add("Positivos: " + positivos);
                lstResultados.Items.Add("Negativos: " + negativos);
                btnAgregar.Enabled = false;
            }

            txtNumero.Clear();
            txtNumero.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            contador = 0; pares = 0; impares = 0; positivos = 0; negativos = 0;
            txtNumero.Clear();
            lstResultados.Items.Clear();
            lblEstado.Text = "Faltan 50 numeros";
            btnAgregar.Enabled = true;
            txtNumero.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
