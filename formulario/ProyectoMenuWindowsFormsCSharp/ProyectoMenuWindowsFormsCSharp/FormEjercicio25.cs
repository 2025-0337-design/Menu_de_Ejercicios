// Ejercicio 25 - Hipotenusa de un triangulo rectangulo
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio25 : Form
    {
        public FormEjercicio25()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtCatetoA.Text, out double catetoa))
            {
                MessageBox.Show("Ingresa un numero valido en el primer cateto");
                return;
            }
            if (!double.TryParse(txtCatetoB.Text, out double catetob))
            {
                MessageBox.Show("Ingresa un numero valido en el segundo cateto");
                return;
            }

            double hipotenusa = Math.Round(Math.Pow(Math.Pow(catetoa, 2) + Math.Pow(catetob, 2), 0.5), 2);
            lblResultado.Text = "La hipotenusa es: " + hipotenusa;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCatetoA.Clear(); txtCatetoB.Clear();
            lblResultado.Text = "";
            txtCatetoA.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
