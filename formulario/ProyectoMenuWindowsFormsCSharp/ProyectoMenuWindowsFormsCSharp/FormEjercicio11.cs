// Ejercicio 11 - Factura con IVA
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio11 : Form
    {
        public FormEjercicio11()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtPrecio.Text, out double precio))
            {
                MessageBox.Show("Ingresa un numero valido en precio");
                return;
            }
            if (!double.TryParse(txtArticulos.Text, out double numeroarticulos))
            {
                MessageBox.Show("Ingresa un numero valido en articulos");
                return;
            }

            double precioventa = precio * numeroarticulos;
            double iva = Math.Round(precioventa * 0.15, 2);
            double preciobruto = precioventa + iva;
            double descuento = preciobruto >= 50 ? Math.Round((preciobruto * 5) / 100, 2) : 0;
            double totalpagar = preciobruto - descuento;

            lstFactura.Items.Clear();
            lstFactura.Items.Add("-- Datos de la factura --");
            lstFactura.Items.Add("Precio de venta: " + precioventa);
            lstFactura.Items.Add("IVA (15%): " + iva);
            lstFactura.Items.Add("Precio bruto: " + preciobruto);
            lstFactura.Items.Add("Descuento: " + descuento);
            lstFactura.Items.Add("Total a pagar: " + totalpagar);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrecio.Clear();
            txtArticulos.Clear();
            lstFactura.Items.Clear();
            txtPrecio.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
