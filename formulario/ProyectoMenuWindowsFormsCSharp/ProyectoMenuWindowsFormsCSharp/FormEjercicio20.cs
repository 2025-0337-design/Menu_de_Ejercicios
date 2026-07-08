// Ejercicio 20 - Ecuacion cuadratica
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio20 : Form
    {
        public FormEjercicio20()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtA.Text, out double coefA) ||
                !double.TryParse(txtB.Text, out double coefB) ||
                !double.TryParse(txtC.Text, out double coefC))
            {
                MessageBox.Show("Ingresa numeros validos en los tres coeficientes");
                return;
            }

            double disc = (Math.Pow(coefB, 2)) - 4 * coefA * coefC;

            if (coefA == 0)
            {
                lblResultado.Text = "El coeficiente 'a' debe ser diferente de 0";
            }
            else if (disc > 0)
            {
                double s1 = Math.Round((-coefB + Math.Pow(disc, 0.5)) / (2 * coefA), 2);
                double s2 = Math.Round((-coefB - Math.Pow(disc, 0.5)) / (2 * coefA), 2);
                lblResultado.Text = "Discriminante positivo. x1 = " + s1 + "  y  x2 = " + s2;
            }
            else if (disc == 0)
            {
                double s3 = Math.Round((-coefB / (2 * coefA)), 2);
                lblResultado.Text = "Discriminante es 0. Solucion unica: s = " + s3;
            }
            else if ((4 * coefA * coefC) > (Math.Pow(coefB, 2)))
            {
                double raiz1 = Math.Round(-coefB / (2 * coefA), 3);
                double raizima1 = Math.Round(Math.Sqrt((4 * coefA * coefC) - Math.Pow(coefB, 2)) / (2 * coefA), 4);
                double raiz2 = Math.Round(-coefB / (2 * coefA), 3);
                double raizima2 = Math.Round(-Math.Sqrt((4 * coefA * coefC) - Math.Pow(coefB, 2)) / (2 * coefA), 4);
                lblResultado.Text = "Raices imaginarias:\nx1 = " + raiz1 + "+i(" + raizima1 + ")   x2 = " + raiz2 + "+i(" + raizima2 + ")";
            }
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
