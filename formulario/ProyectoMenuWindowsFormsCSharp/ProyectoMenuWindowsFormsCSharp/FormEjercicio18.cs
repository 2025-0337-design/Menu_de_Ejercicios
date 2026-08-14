// Ejercicio 18 - Primera vocal ingresada
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio18 : Form
    {
        private bool vocalEncontrada = false;
        private int intentos = 0;

        public FormEjercicio18()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (vocalEncontrada) return;

            string caracter = txtCaracter.Text;
            if (string.IsNullOrEmpty(caracter))
            {
                MessageBox.Show("Escribe un caracter primero");
                return;
            }

            intentos++;
            lblIntentos.Text = "Intentos: " + intentos;

            string c = caracter.ToLower();
            if (c == "a" || c == "e" || c == "i" ||
                c == "o" || c == "u")
            {
                lblResultado.Text = "La primera vocal ingresada fue: \"" + caracter + "\"  (en el intento " + intentos + ")";
                vocalEncontrada = true;
                btnVerificar.Enabled = false;
            }
            else
            {
                lblResultado.Text = "\"" + caracter + "\" no es vocal. Intenta con otro caracter.";
                txtCaracter.Clear();
                txtCaracter.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            vocalEncontrada = false;
            intentos = 0;
            txtCaracter.Clear();
            lblResultado.Text = "";
            lblIntentos.Text = "Intentos: 0";
            btnVerificar.Enabled = true;
            txtCaracter.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e) { this.Close(); }
    }
}
