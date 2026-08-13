// Ejercicio 32 - Claves para la fiesta
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio32 : Form
    {
        public FormEjercicio32()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtClave1.Text != "tienes")
            {
                lblResultado.ForeColor = System.Drawing.Color.Red;
                lblResultado.Text = "TE EQUIVOCASTE DE FIESTA  (clave 1 incorrecta)";
                return;
            }
            if (txtClave2.Text != "que ser")
            {
                lblResultado.ForeColor = System.Drawing.Color.Red;
                lblResultado.Text = "TE EQUIVOCASTE DE FIESTA  (clave 2 incorrecta)";
                return;
            }
            if (txtClave3.Text != "invitado")
            {
                lblResultado.ForeColor = System.Drawing.Color.Red;
                lblResultado.Text = "TE EQUIVOCASTE DE FIESTA  (clave 3 incorrecta)";
                return;
            }
            if (txtClave4.Text != "para")
            {
                lblResultado.ForeColor = System.Drawing.Color.Red;
                lblResultado.Text = "TE EQUIVOCASTE DE FIESTA  (clave 4 incorrecta)";
                return;
            }
            if (txtClave5.Text != "ingresar")
            {
                lblResultado.ForeColor = System.Drawing.Color.Red;
                lblResultado.Text = "TE EQUIVOCASTE DE FIESTA  (clave 5 incorrecta)";
            }
            else
            {
                lblResultado.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
                lblResultado.Text = "BIENVENIDO A LA FIESTA";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtClave1.Clear(); txtClave2.Clear(); txtClave3.Clear();
            txtClave4.Clear(); txtClave5.Clear();
            lblResultado.Text = "";
            txtClave1.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e) { this.Close(); }
        private void btnSalir_Click(object sender, EventArgs e)  { Application.Exit(); }
    }
}
