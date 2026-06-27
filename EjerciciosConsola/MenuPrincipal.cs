using System;

namespace EjerciciosConsola
{
   
    static class MenuPrincipal
    {
        public static void Mostrar()
        {
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("===================================");
                Console.WriteLine(" C# - <<EJERCICIOS EN CONSOLA >>>");
                Console.WriteLine(" 1.  Salarios y Nomina");
                Console.WriteLine(" 2.  Descuentos y Facturacion");
                Console.WriteLine(" 3.  Conversiones de Tiempo");
                Console.WriteLine(" 4.  Series y Sumas Numericas");
                Console.WriteLine(" 5.  Estadisticas y Promedios");
                Console.WriteLine(" 6.  Matematicas y Operaciones Basicas");
                Console.WriteLine(" 7.  Geometria");
                Console.WriteLine(" 8.  Analisis de Numeros");
                Console.WriteLine(" 9.  Matematica Avanzada");
                Console.WriteLine(" 10. Acumuladores con Centinela");
                Console.WriteLine(" 11. Logica y Control de Acceso");
                Console.WriteLine(" 0.  Salir del programa");
                Console.WriteLine("====================================");
                Console.Write(" Selecciona una opcion que exista: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": SubmenuSalariosNomina(); break;
                    case "2": SubmenuDescuentosFacturacion(); break;
                    case "3": SubmenuConversionesTiempo(); break;
                    case "4": SubmenuSeriesSumas(); break;
                    case "5": SubmenuEstadisticasPromedios(); break;
                    case "6": SubmenuMatematicasBasicas(); break;
                    case "7": SubmenuGeometria(); break;
                    case "8": SubmenuAnalisisNumeros(); break;
                    case "9": SubmenuMatematicaAvanzada(); break;
                    case "10": SubmenuAcumuladoresCentinela(); break;
                    case "11": SubmenuLogicaControl(); break;
                    case "0": break;
                    default:
                        Console.WriteLine(" Opcion no valida_presiona Enter para continuar");
                        Console.ReadLine();
                        break;
                }
            }
            while (opcion != "0");

            Console.Clear();
            Console.WriteLine("Hasta luegooo!.");
        }

        private static void SubmenuSalariosNomina()
        {
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("---- 1. SALARIOS Y NOMINA ----");
                Console.WriteLine(" 1. Ejercicio 01 - Salario con horas extras");
                Console.WriteLine(" 2. Ejercicio 02 - Descuentos escalonados sobre sueldo");
                Console.WriteLine(" 3. Ejercicio 07 - Suma de salarios de N trabajadores");
                Console.WriteLine(" 4. Ejercicio 08 - Salario simple");
                Console.WriteLine(" 0. Volver al menu principal");
                Console.Write(" Selecciona un ejercicio: ");
                opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1": Ejercicios.Ejercicio01(); break;
                    case "2": Ejercicios.Ejercicio02(); break;
                    case "3": Ejercicios.Ejercicio07(); break;
                    case "4": Ejercicios.Ejercicio08(); break;
                    case "0": break;
                    default:
                        Console.WriteLine(" Opcion no valida_presiona Enter para continuar");
                        Console.ReadLine();
                        break;
                }
            }
            while (opcion != "0");
        }

        private static void SubmenuDescuentosFacturacion()
        {
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("---- 2. DESCUENTOS Y FACTURACION ----");
                Console.WriteLine(" 1. Ejercicio 03 - Descuento por rangos de un monto");
                Console.WriteLine(" 2. Ejercicio 11 - Factura con IVA y descuento");
                Console.WriteLine(" 3. Ejercicio 27 - Consumos de restaurante");
                Console.WriteLine(" 0. Volver al menu principal");
                Console.Write(" Selecciona un ejercicio: ");
                opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1": Ejercicios.Ejercicio03(); break;
                    case "2": Ejercicios.Ejercicio11(); break;
                    case "3": Ejercicios.Ejercicio27(); break;
                    case "0": break;
                    default:
                        Console.WriteLine(" Opcion no valida_Presiona Enter para continuar");
                        Console.ReadLine();
                        break;
                }
            }
            while (opcion != "0");
        }

        private static void SubmenuConversionesTiempo()
        {
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("---- 3. CONVERSIONES DE TIEMPO ----");
                Console.WriteLine(" 1. Ejercicio 04 - Segundos a minutos y segundos restantes");
                Console.WriteLine(" 2. Ejercicio 05 - Minutos a dias, horas y minutos");
                Console.WriteLine(" 0. Volver al menu principal");
                Console.Write(" Selecciona un ejercicio: ");
                opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1": Ejercicios.Ejercicio04(); break;
                    case "2": Ejercicios.Ejercicio05(); break;
                    case "0": break;
                    default:
                        Console.WriteLine(" Opcion no valida_Presione Enter para continuar");
                        Console.ReadLine();
                        break;
                }
            }
            while (opcion != "0");
        }

        private static void SubmenuSeriesSumas()
        {
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("---- 4. SERIES Y SUMAS NUMERICAS ----");
                Console.WriteLine(" 1. Ejercicio 06 - Suma de los N primeros naturales");
                Console.WriteLine(" 2. Ejercicio 15 - Suma y producto de pares 20-30");
                Console.WriteLine(" 3. Ejercicio 28 - Suma de enteros desde 8 hasta N");
                Console.WriteLine(" 0. Volver al menu principal");
                Console.Write(" Selecciona un ejercicio: ");
                opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1": Ejercicios.Ejercicio06(); break;
                    case "2": Ejercicios.Ejercicio15(); break;
                    case "3": Ejercicios.Ejercicio28(); break;
                    case "0": break;
                    default:
                        Console.WriteLine(" Opcion no valida_Presiona Enter para continuar");
                        Console.ReadLine();
                        break;
                }
            }
            while (opcion != "0");
        }

        private static void SubmenuEstadisticasPromedios()
        {
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("---- 5. ESTADISTICAS Y PROMEDIOS ----");
                Console.WriteLine(" 1. Ejercicio 09 - Estadisticas de notas");
                Console.WriteLine(" 2. Ejercicio 14 - Media de 100 numeros");
                Console.WriteLine(" 3. Ejercicio 30 - Promedio de dos notas");
                Console.WriteLine(" 0. Volver al menu principal");
                Console.Write(" Selecciona un ejercicio: ");
                opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1": Ejercicios.Ejercicio09(); break;
                    case "2": Ejercicios.Ejercicio14(); break;
                    case "3": Ejercicios.Ejercicio30(); break;
                    case "0": break;
                    default:
                        Console.WriteLine(" Opcion no valida_Presiona Enter para continuar");
                        Console.ReadLine();
                        break;
                }
            }
            while (opcion != "0");
        }

        private static void SubmenuMatematicasBasicas()
        {
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("---- 6. MATEMATICAS Y OPERACIONES BASICAS ----");
                Console.WriteLine(" 1. Ejercicio 21 - Cuatro operaciones, 10 veces");
                Console.WriteLine(" 2. Ejercicio 22 - Cubo y raiz cuadrada (hasta 0)");
                Console.WriteLine(" 3. Ejercicio 23 - Cuatro operaciones (hasta 0)");
                Console.WriteLine(" 0. Volver al menu principal");
                Console.Write(" selecciona un ejercicio: ");
                opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1": Ejercicios.Ejercicio21(); break;
                    case "2": Ejercicios.Ejercicio22(); break;
                    case "3": Ejercicios.Ejercicio23(); break;
                    case "0": break;
                    default:
                        Console.WriteLine(" Opcion no valida_presiona Enter para continuar");
                        Console.ReadLine();
                        break;
                }
            }
            while (opcion != "0");
        }

        private static void SubmenuGeometria()
        {
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("---- 7. GEOMETRIA ----");
                Console.WriteLine(" 1. Ejercicio 24 - Area de triangulo (Heron)");
                Console.WriteLine(" 2. Ejercicio 25 - Hipotenusa (Pitagoras)");
                Console.WriteLine(" 3. Ejercicio 26 - Circunferencia, area y volumen");
                Console.WriteLine(" 0. Volver al menu principal");
                Console.Write(" Selecciona un ejercicio: ");
                opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1": Ejercicios.Ejercicio24(); break;
                    case "2": Ejercicios.Ejercicio25(); break;
                    case "3": Ejercicios.Ejercicio26(); break;
                    case "0": break;
                    default:
                        Console.WriteLine(" Opcion no valida_Presione Enter para continuar");
                        Console.ReadLine();
                        break;
                }
            }
            while (opcion != "0");
        }

        private static void SubmenuAnalisisNumeros()
        {
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("---- 8. ANALISIS DE NUMEROS ----");
                Console.WriteLine(" 1. Ejercicio 10 - Suma de digitos de un numero");
                Console.WriteLine(" 2. Ejercicio 12 - 50 numeros: pares/impares/positivos/negativos");
                Console.WriteLine(" 3. Ejercicio 13 - Factorial de un numero");
                Console.WriteLine(" 4. Ejercicio 18 - Primera vocal ingresada");
                Console.WriteLine(" 5. Ejercicio 19 - ¿Tiene parte fraccionaria?");
                Console.WriteLine(" 0. Volver al menu principal");
                Console.Write(" Selecciona un ejercicio: ");
                opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1": Ejercicios.Ejercicio10(); break;
                    case "2": Ejercicios.Ejercicio12(); break;
                    case "3": Ejercicios.Ejercicio13(); break;
                    case "4": Ejercicios.Ejercicio18(); break;
                    case "5": Ejercicios.Ejercicio19(); break;
                    case "0": break;
                    default:
                        Console.WriteLine(" Opcion no valida_presione Enter para continuar");
                        Console.ReadLine();
                        break;
                }
            }
            while (opcion != "0");
        }

        private static void SubmenuMatematicaAvanzada()
        {
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("---- 9. MATEMATICA AVANZADA ----");
                Console.WriteLine(" 1. Ejercicio 20 - Ecuacion cuadratica");
                Console.WriteLine(" 0. Volver al menu principal");
                Console.Write(" Selecciona un ejercicio: ");
                opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1": Ejercicios.Ejercicio20(); break;
                    case "0": break;
                    default:
                        Console.WriteLine(" Opcion no valida_Presione Enter para continuar");
                        Console.ReadLine();
                        break;
                }
            }
            while (opcion != "0");
        }

        private static void SubmenuAcumuladoresCentinela()
        {
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("---- 10. ACUMULADORES CON CENTINELA ----");
                Console.WriteLine(" 1. Ejercicio 29 - Egresos de caja (empresa Barner)");
                Console.WriteLine(" 2. Ejercicio 31 - Clasificar personas por deporte");
                Console.WriteLine(" 0. Volver al menu principal");
                Console.Write(" Selecciona un ejercicio: ");
                opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1": Ejercicios.Ejercicio29(); break;
                    case "2": Ejercicios.Ejercicio31(); break;
                    case "0": break;
                    default:
                        Console.WriteLine(" Opcion no valida_presione Enter para continuar");
                        Console.ReadLine();
                        break;
                }
            }
            while (opcion != "0");
        }

        private static void SubmenuLogicaControl()
        {
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("---- 11. LOGICA Y CONTROL DE ACCESO ----");
                Console.WriteLine(" 1. Ejercicio 32 - Control de acceso a fiesta (5 claves)");
                Console.WriteLine(" 0. Volver al menu principal");
                Console.Write(" Selecciona un ejercicio: ");
                opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1": Ejercicios.Ejercicio32(); break;
                    case "0": break;
                    default:
                        Console.WriteLine(" Opcion no valida_presione Enter para continuar");
                        Console.ReadLine();
                        break;
                }
            }
            while (opcion != "0");
        }
    }
}
