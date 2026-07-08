// Ejercicio 26 - Circunferencia, area y volumen
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio26 : Form
    {
        public FormEjercicio26()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRadio.Text, out int radio))
            {
                MessageBox.Show("Ingresa un numero entero valido");
                return;
            }

            double pi = 3.14;
            double longitud = 2 * pi * radio;
            double area = Math.Round(pi * Math.Pow(radio, 2), 2);
            double volumen = Math.Round((4 / 3) * pi * Math.Pow(radio, 3), 2);

            lstResultados.Items.Clear();
            lstResultados.Items.Add("Longitud de la circunferencia: " + longitud);
            lstResultados.Items.Add("Area de la circunferencia: " + area);
            lstResultados.Items.Add("Volumen de la esfera: " + volumen);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRadio.Clear();
            lstResultados.Items.Clear();
            txtRadio.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
