// Ejercicio 31 - Clasificar deportes
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio31 : Form
    {
        private int c = 1;
        private int vole = 0, fut = 0, aje = 0, basq = 0;

        public FormEjercicio31()
        {
            InitializeComponent();
            cmbDeporte.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (c > 10)
            {
                MessageBox.Show("Ya se ingresaron los 10 alumnos");
                return;
            }

            string deporte = cmbDeporte.SelectedItem.ToString();

            if (deporte == "voley") vole++;
            else if (deporte == "futbol") fut++;
            else if (deporte == "basquet") basq++;
            else if (deporte == "ajedrez") aje++;

            c = c + 1;

            if (c <= 10)
            {
                lblEstado.Text = "Alumnos: " + (c - 1) + " de 10";
            }
            else
            {
                lstResultados.Items.Add("Cantidad de voley: " + vole);
                lstResultados.Items.Add("Cantidad de futbol: " + fut);
                lstResultados.Items.Add("Cantidad de basquet: " + basq);
                lstResultados.Items.Add("Cantidad de ajedrez: " + aje);
                lblEstado.Text = "Proceso terminado";
                btnAgregar.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            c = 1; vole = 0; fut = 0; aje = 0; basq = 0;
            lstResultados.Items.Clear();
            lblEstado.Text = "Alumnos: 0 de 10";
            cmbDeporte.SelectedIndex = 0;
            btnAgregar.Enabled = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
