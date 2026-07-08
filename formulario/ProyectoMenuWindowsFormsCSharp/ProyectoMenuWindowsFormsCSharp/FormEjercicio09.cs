// Ejercicio 09 - Notas de un estudiante
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio09 : Form
    {
        private double ca = 0;
        private double cd = 0;
        private double acumuladasapro = 0;
        private double acumuladasdesapro = 0;
        private double acumuladas = 0;
        private double x = 0;

        public FormEjercicio09()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNota.Text, out int notaInt))
            {
                MessageBox.Show("Ingresa un numero entero valido");
                return;
            }
            double nota = notaInt;

            if (nota <= 10.5 && nota >= 0)
            {
                cd = cd + 1;
                acumuladasdesapro = acumuladasdesapro + nota;
            }
            else if (nota > 10.5 && nota < 20)
            {
                ca = ca + 1;
                acumuladasapro = acumuladasapro + nota;
            }
            acumuladas = acumuladas + nota;
            x = cd + ca;

            lstResultados.Items.Add("Nota ingresada: " + nota + (nota <= 10.5 ? "  (desaprobada)" : "  (aprobada)"));
            txtNota.Clear();
            txtNota.Focus();

            btnTerminar.Enabled = true;
            lblEstado.Text = "Notas ingresadas: " + (int)x + "  -  Agregar otra o ver resultados";
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            double promedioaprobadas = ca > 0 ? Math.Round(acumuladasapro / ca, 1) : 0;
            double promediodesaprobadas = cd > 0 ? Math.Round(acumuladasdesapro / cd, 1) : 0;
            double promedio = x > 0 ? Math.Round(acumuladas / x, 1) : 0;

            lstResultados.Items.Add("-----------------------------");
            lstResultados.Items.Add("Notas desaprobadas: " + cd);
            lstResultados.Items.Add("Notas aprobadas: " + ca);
            lstResultados.Items.Add("Promedio aprobadas: " + promedioaprobadas);
            lstResultados.Items.Add("Promedio desaprobadas: " + promediodesaprobadas);
            lstResultados.Items.Add("Promedio final: " + promedio);

            btnAgregar.Enabled = false;
            btnTerminar.Enabled = false;
            lblEstado.Text = "Proceso terminado";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ca = 0; cd = 0; acumuladasapro = 0;
            acumuladasdesapro = 0; acumuladas = 0; x = 0;
            txtNota.Clear();
            lstResultados.Items.Clear();
            lblEstado.Text = "Ingresa al menos una nota";
            btnAgregar.Enabled = true;
            btnTerminar.Enabled = false;
            txtNota.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
