// Ejercicio 07 - Suma de salarios de varios trabajadores
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio07 : Form
    {
        private int cantidadTrabajadores;
        private int contador;
        private double sumaSalarios;

        public FormEjercicio07()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCantidad.Text, out cantidadTrabajadores) || cantidadTrabajadores <= 0)
            {
                MessageBox.Show("Ingresa una cantidad de trabajadores valida");
                return;
            }

            contador = 0;
            sumaSalarios = 0;
            lstTrabajadores.Items.Clear();
            lblResultado.Text = "";

            txtCantidad.Enabled = false;
            btnIniciar.Enabled = false;
            txtHoras.Enabled = true;
            txtTarifa.Enabled = true;
            btnAgregar.Enabled = true;
            lblContador.Text = "Trabajador 1 de " + cantidadTrabajadores;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtHoras.Text, out double horastrabajadas))
            {
                MessageBox.Show("Ingresa un numero valido en horas trabajadas");
                return;
            }
            if (!double.TryParse(txtTarifa.Text, out double tarifa))
            {
                MessageBox.Show("Ingresa un numero valido en tarifa");
                return;
            }

            double salario = horastrabajadas * tarifa;
            sumaSalarios = sumaSalarios + salario;
            contador = contador + 1;

            lstTrabajadores.Items.Add("Trabajador " + contador + ": salario " + salario);
            txtHoras.Clear();
            txtTarifa.Clear();

            if (contador >= cantidadTrabajadores)
            {
                lblResultado.Text = "La suma de los salarios es: " + sumaSalarios;
                btnAgregar.Enabled = false;
                txtHoras.Enabled = false;
                txtTarifa.Enabled = false;
                lblContador.Text = "Proceso terminado";
            }
            else
            {
                lblContador.Text = "Trabajador " + (contador + 1) + " de " + cantidadTrabajadores;
                txtHoras.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtHoras.Clear();
            txtTarifa.Clear();
            lstTrabajadores.Items.Clear();
            lblResultado.Text = "";
            lblContador.Text = "Ingresa la cantidad";
            contador = 0;
            cantidadTrabajadores = 0;
            sumaSalarios = 0;
            txtCantidad.Enabled = true;
            btnIniciar.Enabled = true;
            txtHoras.Enabled = false;
            txtTarifa.Enabled = false;
            btnAgregar.Enabled = false;
            txtCantidad.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
