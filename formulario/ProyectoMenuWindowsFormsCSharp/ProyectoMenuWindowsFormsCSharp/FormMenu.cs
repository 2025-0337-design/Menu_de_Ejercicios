using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            CargarEjercicios();
        }

        private void CargarEjercicios()
        {
            lstEjercicios.Items.Add("01 - Salario con horas extra");
            lstEjercicios.Items.Add("02 - Descuento de sueldo");
            lstEjercicios.Items.Add("03 - Descuento por monto");
            lstEjercicios.Items.Add("04 - Segundos a minutos");
            lstEjercicios.Items.Add("05 - Minutos a dias, horas y minutos");
            lstEjercicios.Items.Add("06 - Suma de los primeros N numeros");
            lstEjercicios.Items.Add("07 - Suma de salarios de varios trabajadores");
            lstEjercicios.Items.Add("08 - Salario simple");
            lstEjercicios.Items.Add("09 - Notas de un estudiante");
            lstEjercicios.Items.Add("10 - Suma de los digitos de un numero");
            lstEjercicios.Items.Add("11 - Factura con IVA");
            lstEjercicios.Items.Add("12 - Clasificar 50 numeros");
            lstEjercicios.Items.Add("13 - Factorial de un numero");
            lstEjercicios.Items.Add("14 - Media de 100 numeros");
            lstEjercicios.Items.Add("15 - Suma y producto de pares del 20 al 30");
            lstEjercicios.Items.Add("18 - Primera vocal ingresada");
            lstEjercicios.Items.Add("19 - Parte fraccionaria");
            lstEjercicios.Items.Add("20 - Ecuacion cuadratica");
            lstEjercicios.Items.Add("21 - 10 procesos con dos numeros");
            lstEjercicios.Items.Add("22 - Cubo y raiz cuadrada");
            lstEjercicios.Items.Add("23 - Operaciones hasta ingresar cero");
            lstEjercicios.Items.Add("24 - Area de un triangulo");
            lstEjercicios.Items.Add("25 - Hipotenusa de un triangulo rectangulo");
            lstEjercicios.Items.Add("26 - Circunferencia, area y volumen");
            lstEjercicios.Items.Add("27 - Consumos de un restaurant");
            lstEjercicios.Items.Add("28 - Suma desde el 8 hasta N");
            lstEjercicios.Items.Add("29 - Caja de la compania Barner");
            lstEjercicios.Items.Add("30 - Promedio de dos notas");
            lstEjercicios.Items.Add("31 - Clasificar deportes");
            lstEjercicios.Items.Add("32 - Claves para la fiesta");
            lstEjercicios.SelectedIndex = 0;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            AbrirEjercicio();
        }

        private void lstEjercicios_DoubleClick(object sender, EventArgs e)
        {
            AbrirEjercicio();
        }

        private void AbrirEjercicio()
        {
            Form ejercicio = null;

            switch (lstEjercicios.SelectedIndex)
            {
                case 0: ejercicio = new FormEjercicio01(); break;
                case 1: ejercicio = new FormEjercicio02(); break;
                case 2: ejercicio = new FormEjercicio03(); break;
                case 3: ejercicio = new FormEjercicio04(); break;
                case 4: ejercicio = new FormEjercicio05(); break;
                case 5: ejercicio = new FormEjercicio06(); break;
                case 6: ejercicio = new FormEjercicio07(); break;
                case 7: ejercicio = new FormEjercicio08(); break;
                case 8: ejercicio = new FormEjercicio09(); break;
                case 9: ejercicio = new FormEjercicio10(); break;
                case 10: ejercicio = new FormEjercicio11(); break;
                case 11: ejercicio = new FormEjercicio12(); break;
                case 12: ejercicio = new FormEjercicio13(); break;
                case 13: ejercicio = new FormEjercicio14(); break;
                case 14: ejercicio = new FormEjercicio15(); break;
                case 15: ejercicio = new FormEjercicio18(); break;
                case 16: ejercicio = new FormEjercicio19(); break;
                case 17: ejercicio = new FormEjercicio20(); break;
                case 18: ejercicio = new FormEjercicio21(); break;
                case 19: ejercicio = new FormEjercicio22(); break;
                case 20: ejercicio = new FormEjercicio23(); break;
                case 21: ejercicio = new FormEjercicio24(); break;
                case 22: ejercicio = new FormEjercicio25(); break;
                case 23: ejercicio = new FormEjercicio26(); break;
                case 24: ejercicio = new FormEjercicio27(); break;
                case 25: ejercicio = new FormEjercicio28(); break;
                case 26: ejercicio = new FormEjercicio29(); break;
                case 27: ejercicio = new FormEjercicio30(); break;
                case 28: ejercicio = new FormEjercicio31(); break;
                case 29: ejercicio = new FormEjercicio32(); break;
            }

            if (ejercicio != null)
            {
                ejercicio.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
