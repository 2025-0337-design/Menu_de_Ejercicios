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
            string c1 = txtClave1.Text;
            if (c1 != "tienes")
            {
                lblResultado.Text = "TE EQUIVOCASTE DE FIESTA";
                return;
            }

            string c2 = txtClave2.Text;
            if (c2 != "que ser")
            {
                lblResultado.Text = "TE EQUIVOCASTE DE FIESTA";
                return;
            }

            string c3 = txtClave3.Text;
            if (c3 != "invitado")
            {
                lblResultado.Text = "TE EQUIVOCASTE DE FIESTA";
                return;
            }

            string c4 = txtClave4.Text;
            if (c4 != "para")
            {
                lblResultado.Text = "TE EQUIVOCASTE DE FIESTA";
                return;
            }

            string c5 = txtClave5.Text;
            if (c5 != "ingresar")
                lblResultado.Text = "TE EQUIVOCASTE DE FIESTA";
            else
                lblResultado.Text = "BIENVENIDO A LA FIESTA";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtClave1.Clear(); txtClave2.Clear(); txtClave3.Clear();
            txtClave4.Clear(); txtClave5.Clear();
            lblResultado.Text = "";
            txtClave1.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
