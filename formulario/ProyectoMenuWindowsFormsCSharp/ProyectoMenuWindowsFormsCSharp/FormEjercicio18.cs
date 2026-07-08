// Ejercicio 18 - Primera vocal ingresada
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio18 : Form
    {
        private bool vocalEncontrada = false;

        public FormEjercicio18()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (vocalEncontrada)
            {
                MessageBox.Show("Ya se encontro la primera vocal");
                return;
            }

            string caracter = txtCaracter.Text;
            if (string.IsNullOrEmpty(caracter))
            {
                MessageBox.Show("Ingresa un caracter");
                return;
            }

            if (caracter.Equals("a") || caracter.Equals("e") || caracter.Equals("i") ||
                caracter.Equals("o") || caracter.Equals("u"))
            {
                lblResultado.Text = "La primera vocal ingresada fue: " + caracter;
                vocalEncontrada = true;
                btnVerificar.Enabled = false;
            }
            else
            {
                lblResultado.Text = "\"" + caracter + "\" no es vocal, intenta con otro caracter";
                txtCaracter.Clear();
                txtCaracter.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            vocalEncontrada = false;
            txtCaracter.Clear();
            lblResultado.Text = "";
            btnVerificar.Enabled = true;
            txtCaracter.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
