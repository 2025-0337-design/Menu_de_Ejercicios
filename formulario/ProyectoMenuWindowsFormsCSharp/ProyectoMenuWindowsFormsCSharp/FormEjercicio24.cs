// Ejercicio 24 - Area de un triangulo
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio24 : Form
    {
        public FormEjercicio24()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtA.Text, out double ladoa) ||
                !double.TryParse(txtB.Text, out double ladob) ||
                !double.TryParse(txtC.Text, out double ladoc))
            {
                MessageBox.Show("Ingresa numeros validos en los tres lados");
                return;
            }

            double sm = (ladoa + ladob + ladoc) / 2;
            double areatriangulo = Math.Round(Math.Pow(sm * (sm - ladoa) * sm * (sm - ladob) * sm * (sm - ladoc), 0.5), 2);
            lblResultado.Text = "El area del triangulo es: " + areatriangulo;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtA.Clear(); txtB.Clear(); txtC.Clear();
            lblResultado.Text = "";
            txtA.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
