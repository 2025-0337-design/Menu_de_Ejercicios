using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormMenu : Form
    {
        // Cada categoria tiene: nombre para mostrar y lista de (numero, texto)
        private readonly List<(string nombre, List<(int num, string texto)> ejercicios)> categorias;

        // Numeros de ejercicio de la categoria actualmente mostrada
        private List<int> numerosActuales = new List<int>();

        // Boton actualmente seleccionado
        private Button btnSeleccionado = null;

        // Color activo del boton de categoria
        private readonly Color colorActivo   = Color.FromArgb(46, 134, 193);
        private readonly Color colorInactivo = Color.FromArgb(44, 62, 80);

        public FormMenu()
        {
            InitializeComponent();
            categorias = DefinirCategorias();
            // Seleccionar la primera categoria al abrir
            SeleccionarCategoria(btnCat1, 0);
        }

        private List<(string, List<(int, string)>)> DefinirCategorias()
        {
            return new List<(string, List<(int, string)>)>
            {
                (
                    "Condicionales  (if / else)",
                    new List<(int, string)>
                    {
                        (1,  "01 - Salario con horas extra"),
                        (2,  "02 - Descuento de sueldo"),
                        (3,  "03 - Descuento por monto"),
                        (4,  "04 - Segundos a minutos"),
                        (5,  "05 - Minutos a dias, horas y minutos"),
                        (8,  "08 - Salario simple"),
                        (18, "18 - Primera vocal ingresada"),
                        (19, "19 - Parte fraccionaria"),
                        (30, "30 - Promedio de dos notas"),
                        (32, "32 - Claves para la fiesta"),
                    }
                ),
                (
                    "Bucles con for",
                    new List<(int, string)>
                    {
                        (6,  "06 - Suma de los primeros N numeros"),
                        (12, "12 - Clasificar 50 numeros"),
                        (13, "13 - Factorial de un numero"),
                        (14, "14 - Media de 100 numeros"),
                        (15, "15 - Suma y producto de pares del 20 al 30"),
                        (27, "27 - Consumos de un restaurant"),
                        (28, "28 - Suma desde el 8 hasta N"),
                    }
                ),
                (
                    "Bucles con while / do-while",
                    new List<(int, string)>
                    {
                        (7,  "07 - Suma de salarios de varios trabajadores"),
                        (9,  "09 - Notas de un estudiante"),
                        (10, "10 - Suma de los digitos de un numero"),
                        (21, "21 - 10 procesos con dos numeros"),
                        (22, "22 - Cubo y raiz cuadrada"),
                        (23, "23 - Operaciones hasta ingresar cero"),
                        (29, "29 - Caja de la compania Barner"),
                        (31, "31 - Clasificar deportes"),
                    }
                ),
                (
                    "Matematicas",
                    new List<(int, string)>
                    {
                        (11, "11 - Factura con IVA"),
                        (20, "20 - Ecuacion cuadratica"),
                        (24, "24 - Area de un triangulo"),
                        (25, "25 - Hipotenusa de un triangulo rectangulo"),
                        (26, "26 - Circunferencia, area y volumen"),
                    }
                ),
            };
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int indice = int.Parse(btn.Tag.ToString());
            SeleccionarCategoria(btn, indice);
        }

        private void SeleccionarCategoria(Button btn, int indice)
        {
            // Restaurar color del boton anterior
            if (btnSeleccionado != null)
                btnSeleccionado.BackColor = colorInactivo;

            // Resaltar boton seleccionado
            btn.BackColor = colorActivo;
            btnSeleccionado = btn;

            // Cargar ejercicios en la lista
            var cat = categorias[indice];
            lblCatActual.Text = cat.nombre;
            lstEjercicios.Items.Clear();
            numerosActuales.Clear();

            foreach (var (num, texto) in cat.ejercicios)
            {
                lstEjercicios.Items.Add(texto);
                numerosActuales.Add(num);
            }

            if (lstEjercicios.Items.Count > 0)
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
            if (lstEjercicios.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un ejercicio de la lista");
                return;
            }

            int numero = numerosActuales[lstEjercicios.SelectedIndex];
            Form ejercicio = CrearFormEjercicio(numero);

            if (ejercicio != null)
                ejercicio.ShowDialog();
        }

        private Form CrearFormEjercicio(int numero)
        {
            switch (numero)
            {
                case 1:  return new FormEjercicio01();
                case 2:  return new FormEjercicio02();
                case 3:  return new FormEjercicio03();
                case 4:  return new FormEjercicio04();
                case 5:  return new FormEjercicio05();
                case 6:  return new FormEjercicio06();
                case 7:  return new FormEjercicio07();
                case 8:  return new FormEjercicio08();
                case 9:  return new FormEjercicio09();
                case 10: return new FormEjercicio10();
                case 11: return new FormEjercicio11();
                case 12: return new FormEjercicio12();
                case 13: return new FormEjercicio13();
                case 14: return new FormEjercicio14();
                case 15: return new FormEjercicio15();
                case 18: return new FormEjercicio18();
                case 19: return new FormEjercicio19();
                case 20: return new FormEjercicio20();
                case 21: return new FormEjercicio21();
                case 22: return new FormEjercicio22();
                case 23: return new FormEjercicio23();
                case 24: return new FormEjercicio24();
                case 25: return new FormEjercicio25();
                case 26: return new FormEjercicio26();
                case 27: return new FormEjercicio27();
                case 28: return new FormEjercicio28();
                case 29: return new FormEjercicio29();
                case 30: return new FormEjercicio30();
                case 31: return new FormEjercicio31();
                case 32: return new FormEjercicio32();
                default: return null;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
