using System;

namespace EjerciciosConsola
{
    // Todas las funciones de los ejercicios extraidos del documento original
    // de Braulio Ricardo Alvarez Gonzaga. La logica interna de cada ejercicio
    // se mantiene igual que en el PDF; solo se convirtio en metodo para poder
    // llamarla desde el menu.
    static class Ejercicios
    {
        // ---------------------------------------------------------------
        // Ejercicio 01
        // A un trabajador le pagan segun sus horas y una tarifa de pago por
        // hora. Si la cantidad de horas trabajadas es mayor a 40 horas, la
        // tarifa se incrementa en un 50% para las horas extras.
        // ---------------------------------------------------------------
        public static void Ejercicio01()
        {
            double tarifa, horastrabajadas, horasextra, salario, tarifaextra;
            Console.WriteLine("ingrese horas trabajadas");
            horastrabajadas = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese tarifa");
            tarifa = double.Parse(Console.ReadLine());
            if (horastrabajadas <= 40 && horastrabajadas >= 0)
            {
                salario = horastrabajadas * tarifa;
                Console.WriteLine("el salario es: " + salario);
            }
            else if (horastrabajadas > 40)
            {
                horasextra = horastrabajadas - 40;
                tarifaextra = tarifa + 0.5 * tarifa;
                salario = horasextra * tarifaextra + 40 * tarifa;
                Console.WriteLine("el salario es: " + salario);
            }
            else
                Console.WriteLine("las horas trabajadas no pueden ser negativas");
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 02
        // A un trabajador le descuentan de su sueldo el 10% si su sueldo es
        // menor o igual a 1000. Por encima de 1000 y hasta 2000 el 5% del
        // adicional, y por encima de 2000 el 3% del adicional.
        // ---------------------------------------------------------------
        public static void Ejercicio02()
        {
            double sueldo, sueldoneto, descuento;
            Console.WriteLine("ingrese el sueldo");
            sueldo = double.Parse(Console.ReadLine());
            if (sueldo <= 1000 && sueldo >= 0)
            {
                descuento = sueldo * 0.1;
                sueldoneto = sueldo - descuento;
                Console.WriteLine("el descuento es: {0} y el sueldo neto es: {1}", descuento, sueldoneto);
            }
            else if (sueldo <= 2000 && sueldo >= 0)
            {
                descuento = (sueldo - 1000) * 0.05 + (1000 * 0.1);
                sueldoneto = sueldo - descuento;
                Console.WriteLine("el descuento es: {0} y el sueldo neto es: {1}", descuento, sueldoneto);
            }
            else if (sueldo > 2000)
            {
                descuento = (sueldo - 2000) * 0.03 + (1000 * 0.05) + (1000 * 0.10);
                sueldoneto = sueldo - descuento;
                Console.WriteLine("el descuento es: {0} y el sueldo neto es: {1}", descuento, sueldoneto);
            }
            else
                Console.WriteLine("error el sueldo no puede ser negativo");
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 03
        // Dado un monto calcular el descuento considerando que por encima
        // de 100 el descuento es el 10% y por debajo de 100 el descuento
        // es el 2% (segun codigo original: 20%).
        // ---------------------------------------------------------------
        public static void Ejercicio03()
        {
            double monto, descuento;
            Console.WriteLine("ingrese monto");
            monto = double.Parse(Console.ReadLine());
            if (monto > 100)
            {
                descuento = monto * 0.1;
                Console.WriteLine("el monto  {0} tiene un descuento del {1}", monto, descuento);
            }
            else if (monto <= 100 && monto > 0)
            {
                descuento = monto * 0.2;
                Console.WriteLine("el monto  {0} tiene un descuento del {1}", monto, descuento);
            }
            else
            {
                Console.WriteLine("error el monto no puede ser negativo");
            }
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 04
        // Dado un tiempo en segundos, calcular los segundos restantes que
        // le correspondan para convertirse exactamente en minutos.
        // ---------------------------------------------------------------
        public static void Ejercicio04()
        {
            int tiemposegundos, minutos, segundosrestantes;
            Console.WriteLine("ingrese el tiempo en segundos");
            tiemposegundos = int.Parse(Console.ReadLine());
            if (tiemposegundos < 60 && tiemposegundos > 0)
            {
                segundosrestantes = 60 - tiemposegundos;
                Console.WriteLine("Le falta {0} segundos para convertirse en minuto", segundosrestantes);
            }
            else if (tiemposegundos >= 60)
            {
                minutos = (tiemposegundos - (tiemposegundos % 60)) / 60;
                segundosrestantes = tiemposegundos % 60;
                Console.WriteLine("equivale a {0} minutos y le faltan {1} segundos para convertirse en minuto", minutos, segundosrestantes);
            }
            else
            {
                Console.WriteLine("la cantidad de segundos debe ser un numero positivo");
            }
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 05
        // Dado un tiempo en minutos, calcular los dias, horas y minutos
        // que le corresponden.
        // ---------------------------------------------------------------
        public static void Ejercicio05()
        {
            int tiempo, dias, horas, minutos, x;
            Console.WriteLine("ingrese un tiempo en minutos");
            tiempo = int.Parse(Console.ReadLine());
            if (tiempo >= 0)
            {
                dias = (tiempo - (tiempo % 60)) / 1440;
                x = tiempo % 1440;
                horas = (x - (x % 60)) / 60;
                minutos = x % 60;
                Console.WriteLine("equivale a {0} dias con {1} horas y {2} minutos", dias, horas, minutos);
            }
            else
            {
                Console.WriteLine("el tiempo no puede ser negativo");
            }
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 06
        // Calcular mediante un algoritmo repetitivo la suma de los N
        // primeros numeros naturales.
        // ---------------------------------------------------------------
        public static void Ejercicio06()
        {
            int x, numero, suma;
            Console.Write("ingrese el numero N :  ");
            numero = int.Parse(Console.ReadLine());
            suma = 0;
            for (x = 1; x <= numero; x = x + 1)
            {
                suma = suma + x;
                Console.WriteLine("n{0}: {1}", x, x);
            }
            Console.WriteLine("");
            Console.WriteLine("La suma de la serie es: {0}", suma);
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 07
        // Modificar el ejercicio 1 para obtener la suma de los salarios
        // de todos los trabajadores.
        // ---------------------------------------------------------------
        public static void Ejercicio07()
        {
            double x, salario, horastrabajadas, tarifa, suma, numerotrabajadores;
            suma = 0;
            Console.Write("ingrese la cantidad de trabajadores: ");
            numerotrabajadores = double.Parse(Console.ReadLine());
            for (x = 1; x <= numerotrabajadores; x = x + 1)
            {
                Console.WriteLine(" trabajador {0}: ", x);
                Console.Write(" horas trabajasdas : ");
                horastrabajadas = double.Parse(Console.ReadLine());
                Console.Write(" tarifa : ");
                tarifa = double.Parse(Console.ReadLine());
                Console.WriteLine("");
                salario = horastrabajadas * tarifa;
                suma = suma + salario;
            }
            Console.WriteLine("la suma de los salarios es : {0}", suma);
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 08
        // Dada las horas trabajadas de una persona y la tarifa de pago,
        // calcular su salario e imprimirlo.
        // ---------------------------------------------------------------
        public static void Ejercicio08()
        {
            double horastrabajadas, tarifa, salario;
            Console.Write("ingrese horas trabajadas: ");
            horastrabajadas = double.Parse(Console.ReadLine());
            Console.Write("ingrese tarifa:  ");
            tarifa = double.Parse(Console.ReadLine());
            salario = horastrabajadas * tarifa;
            Console.WriteLine("El salario del trabajador es: " + salario);
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 09
        // Dado N notas de un estudiante calcular cuantas desaprobadas,
        // cuantas aprobadas, el promedio de notas, y el promedio de notas
        // aprobadas y desaprobadas.
        // ---------------------------------------------------------------
        public static void Ejercicio09()
        {
            double promedio, ca, cd, x, nota, acumuladasdesapro, acumuladasapro, acumuladas, promedioaprobadas, promediodesaprobadas;
            string resp;
            x = 1;
            ca = 0;
            cd = 0;
            acumuladas = 0;
            acumuladasapro = 0;
            acumuladasdesapro = 0;
            do
            {
                Console.Write(" Introduce la nota: ");
                nota = int.Parse(Console.ReadLine());
                Console.Write(" ¿deseas ingresar otra nota?: ");
                resp = Console.ReadLine();
                Console.WriteLine("");
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
                promedioaprobadas = Math.Round(acumuladasapro / ca, 1);
                promediodesaprobadas = Math.Round(acumuladasdesapro / cd, 1);
                promedio = Math.Round(acumuladas / x, 1);
            }
            while (resp == "si");
            Console.Clear();
            Console.WriteLine("la cantidad de notas desaprobadas es: " + cd);
            Console.WriteLine("la cantidad de notas aprobadas es: " + ca);
            Console.WriteLine("el promedio de las notas aprobadas es: " + promedioaprobadas);
            Console.WriteLine("el promedio de las notas desaprobadas es: " + promediodesaprobadas);
            Console.WriteLine("el promedio final es: " + promedio);
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 10
        // Dado un numero determinar la suma de sus digitos.
        // ---------------------------------------------------------------
        public static void Ejercicio10()
        {
            int numero, suma, residuo;
            suma = 0;
            Console.WriteLine("ingresar un numero");
            numero = int.Parse(Console.ReadLine());
            do
            {
                residuo = numero % 10;
                suma = suma + residuo;
                numero = (numero - (numero % 10)) / 10;
            }
            while (numero != 0);
            {
                Console.WriteLine("");
                Console.WriteLine("la suma es de los digitos es:  {0} ", suma);
            }
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 11
        // Escribir el algoritmo que permita emitir la factura
        // correspondiente a una compra. El IVA es del 15% y si el precio
        // bruto es mayor de 50.00 se debe realizar un descuento del 5%.
        // ---------------------------------------------------------------
        public static void Ejercicio11()
        {
            double precio, numeroarticulos, precioventa, descuento, preciobruto, iva, totalpagar;
            Console.Write("ingrese el precio: ");
            precio = double.Parse(Console.ReadLine());
            Console.Write("ingrese numero de articulos: ");
            numeroarticulos = double.Parse(Console.ReadLine());
            precioventa = precio * numeroarticulos;
            iva = Math.Round(precioventa * 0.15, 2);
            preciobruto = precioventa + iva;
            if (preciobruto >= 50)
            {
                descuento = Math.Round((preciobruto * 5) / 100, 2);
            }
            else
            {
                descuento = 0;
            }
            totalpagar = preciobruto - descuento;
            Console.WriteLine(" ");
            Console.WriteLine(" Datos de la factura ");
            Console.WriteLine(" ");
            Console.WriteLine(" Precio de venta : " + precioventa);
            Console.WriteLine(" Impuesto sobre el valor añadido (IVA) es: " + iva);
            Console.WriteLine(" Precio bruto es : " + preciobruto);
            Console.WriteLine(" Descuento es : " + descuento);
            Console.WriteLine(" Total a pagar: " + totalpagar);
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 12
        // Realizar un algoritmo que permita pedir 50 numeros naturales y
        // determine e imprima cuantos son pares, impares, positivos y
        // negativos.
        // ---------------------------------------------------------------
        public static void Ejercicio12()
        {
            int x, numero, positivos, negativos, pares, impares;
            pares = 0;
            impares = 0;
            positivos = 0;
            negativos = 0;
            for (x = 1; x <= 50; x = x + 1)
            {
                Console.Write("ingrese {0}° numero:   ", x);
                numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    pares = pares + 1;
                }
                else
                {
                    impares = impares + 1;
                }
                if (numero > 0)
                {
                    positivos = positivos + 1;
                }
                else
                {
                    negativos = negativos + 1;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("la cantidad de numeros pares es: " + pares);
            Console.WriteLine("la cantidad de numeros impares es: " + impares);
            Console.WriteLine("la cantidad de numeros negativos es: " + negativos);
            Console.WriteLine("la cantidad de numeros positivos es: " + positivos);
            Console.ReadLine();
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 13
        // Desarrollar un algoritmo para calcular e imprimir el factorial
        // de un numero.
        // ---------------------------------------------------------------
        public static void Ejercicio13()
        {
            int numero, factorial, i;
            Console.Write("ingresar numero: ");
            numero = int.Parse(Console.ReadLine());
            factorial = 1;
            for (i = 1; i <= numero; i++)
                factorial = factorial * i; //factorial *= i
            Console.WriteLine("");
            Console.WriteLine("Factorial: ");
            Console.WriteLine(" {0}! = {1} ", numero, factorial);
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 14
        // Calcular la media de 100 numeros e imprimir su resultado.
        // ---------------------------------------------------------------
        public static void Ejercicio14()
        {
            double suma, media, x, numero;
            suma = 0;
            for (x = 1; x <= 100; x = x + 1)
            {
                Console.Write("ingrese  {0}° numero:  ", x);
                numero = double.Parse(Console.ReadLine());
                suma = suma + numero;
            }
            media = Math.Round(suma / 100, 2);
            Console.WriteLine("");
            Console.WriteLine("la media de los 100 numero ingresados es: " + media);
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 15
        // Calcular y visualizar la suma y el producto de los numeros
        // pares comprendidos entre 20 y 400 ambos inclusive.
        // NOTA / DISCREPANCIA: el enunciado del PDF dice "20 y 400", pero
        // el codigo original implementado usa el rango 20 a 30. Se
        // preserva el codigo tal cual aparece en el documento.
        // ---------------------------------------------------------------
        public static void Ejercicio15()
        {
            int suma, producto, x;
            suma = 0;
            producto = 1;
            for (x = 20; x <= 30; x = x + 2)
            {
                suma = suma + x;
                producto = producto * x;
            }
            Console.WriteLine("Rango : numeros pares del 20 al 30");
            Console.WriteLine("");
            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("El producto es: " + producto);
            Console.ReadLine();
        }

        // NOTA: Los ejercicios 16 y 17 no estan presentes en el documento
        // original. La numeracion del PDF salta del ejercicio 15 al 18.

        // ---------------------------------------------------------------
        // Ejercicio 18
        // Hacer un programa para escribir la primera vocal leida del
        // teclado (se asume que se leen, uno a uno, caracteres).
        // ---------------------------------------------------------------
        public static void Ejercicio18()
        {
            string caracter;
            int x;
            x = 1;
            do
            {
                Console.WriteLine("ingrese caracter");
                caracter = Console.ReadLine();
                if (caracter.Equals("a") || (caracter.Equals("e")) || (caracter.Equals("i")) || (caracter.Equals("o")) || (caracter.Equals("u")))
                    x = 0;
            }
            while (x == 1);
            Console.WriteLine("");
            Console.WriteLine("La primera vocal ingresada fue: " + caracter);
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 19
        // Hacer un programa que determine si un numero tiene o no parte
        // fraccionaria.
        // ---------------------------------------------------------------
        public static void Ejercicio19()
        {
            double numero, pf;
            Console.WriteLine("ingrese un numero");
            numero = double.Parse(Console.ReadLine());
            pf = Math.Truncate(numero);
            if (numero == pf)
                Console.WriteLine("no tiene parte fraccionaria");
            else
                Console.WriteLine("tiene parte fraccionaria");
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 20
        // Elaborar un programa que calcule las soluciones de la ecuacion
        // cuadratica, incluyendo las soluciones imaginarias.
        // ---------------------------------------------------------------
        public static void Ejercicio20()
        {
            Console.Title = "soluciones de la ecuacion cuadratica";
            double coefA, coefB, coefC, disc, s1, s2, s3, raiz1, raiz2, raizima1, raizima2;
            Console.WriteLine("dada la ecuacion aX2 + bx + c = 0 ingresar los coeficientes a,b,c para calcular las posibles valores de X");
            Console.WriteLine();
            Console.WriteLine("ingrese el coeficiente a");
            coefA = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el coeficiente b");
            coefB = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el coeficiente c");
            coefC = double.Parse(Console.ReadLine());
            disc = (Math.Pow(coefB, 2)) - 4 * coefA * coefC;
            if (coefA == 0)
                Console.WriteLine("esta no es una ecuacion cuadratica coeficiente 'a' debe ser diferente de 0");
            else
                if (disc > 0)
                {
                    s1 = Math.Round((-coefB + Math.Pow(disc, 0.5)) / (2 * coefA), 2);
                    s2 = Math.Round((-coefB - Math.Pow(disc, 0.5)) / (2 * coefA), 2);
                    Console.WriteLine(" el discriminante es positivo y se han obtenido las siguientes soluciones: x1 = {0} y x2 = {1}", s1, s2);
                }
                else if (disc == 0)
                {
                    s3 = Math.Round((-coefB / (2 * coefA)), 2);
                    Console.WriteLine(" el discriminante es 0 se obtiene la siguiente solucion: s = {0}", s3);
                }
                else if ((4 * coefA * coefC) > (Math.Pow(coefB, 2)))
                {
                    raiz1 = Math.Round(-coefB / (2 * coefA), 3);
                    raizima1 = Math.Round(Math.Sqrt((4 * coefA * coefC) - Math.Pow(coefB, 2)) / (2 * coefA), 4);
                    raiz2 = Math.Round(-coefB / (2 * coefA), 3);
                    raizima2 = Math.Round(-Math.Sqrt((4 * coefA * coefC) - Math.Pow(coefB, 2)) / (2 * coefA), 4);
                    Console.WriteLine(" discrimiante es {0} se obtienen las siguientes raices imaginarias:x1 = {1}+i({2}) , x2= {3}+i({4})", disc, raiz1, raizima1, raiz2, raizima2);
                }
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 21
        // Hacer un programa que al ingresar 2 numeros calcule la suma,
        // resta, multiplicacion y division. El proceso debe terminar
        // cuando se hayan realizado 10 procesos (uso de contadores).
        // ---------------------------------------------------------------
        public static void Ejercicio21()
        {
            double num1, num2, c, suma, resta, multiplicacion, division;
            c = 0;
            do
            {
                c = c + 1;
                Console.WriteLine("PROCESO N°{0}:", c);
                Console.Write("ingrese primer numero: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("ingrese segundo numero: ");
                num2 = double.Parse(Console.ReadLine());
                suma = num1 + num2;
                resta = num1 - num2;
                multiplicacion = num1 * num2;
                division = Math.Round(num1 / num2, 2);
                Console.WriteLine("");
                Console.WriteLine("La suma es: " + suma);
                Console.WriteLine("La resta es : " + resta);
                Console.WriteLine("La multiplicacion es: " + multiplicacion);
                Console.WriteLine("La division es: " + division);
                Console.WriteLine(" ");
            }
            while (c <= 9);
            Console.WriteLine("final del proceso");
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 22
        // Hacer un programa que imprima el cubo y la raiz cuadrada de un
        // numero; el proceso es repetitivo y termina cuando se ingresa 0.
        // ---------------------------------------------------------------
        public static void Ejercicio22()
        {
            double numero, c, cubo, raizcuadrada;
            c = 0;
            do
            {
                c = c + 1;
                Console.WriteLine("PROCESO N°{0}:", c);
                Console.Write("ingrese un numero:  ");
                numero = double.Parse(Console.ReadLine());
                if (numero != 0)
                {
                    cubo = Math.Pow(numero, 3);
                    raizcuadrada = Math.Round(Math.Pow(numero, 0.5), 2);
                    Console.WriteLine("El cubo es: " + cubo);
                    Console.WriteLine("La raiz cuadrada es: " + raizcuadrada);
                    Console.WriteLine("");
                }
            }
            while (numero != 0);
            Console.WriteLine("");
            Console.WriteLine("FINAL DEL PROCESO");
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 23
        // Hacer un programa que ingresados dos numeros calcule la suma,
        // diferencia, producto y division. El proceso finaliza al
        // ingresar el primer numero igual a cero.
        // ---------------------------------------------------------------
        public static void Ejercicio23()
        {
            double num1, num2, c, suma, resta, multiplicacion, division;
            c = 0;
            do
            {
                c = c + 1;
                Console.WriteLine("PROCESO N°{0}:", c);
                Console.Write("ingrese primer numero: ");
                num1 = double.Parse(Console.ReadLine());
                if (num1 != 0)
                {
                    Console.Write("ingrese segundo numero: ");
                    num2 = double.Parse(Console.ReadLine());
                    suma = num1 + num2;
                    resta = num1 - num2;
                    multiplicacion = num1 * num2;
                    division = Math.Round(num1 / num2, 2);
                    Console.WriteLine("");
                    Console.WriteLine("La suma es: " + suma);
                    Console.WriteLine("La resta es : " + resta);
                    Console.WriteLine("La multiplicacion es: " + multiplicacion);
                    Console.WriteLine("La division es: " + division);
                    Console.WriteLine(" ");
                }
            }
            while (num1 != 0);
            Console.WriteLine(" ");
            Console.WriteLine("FINAL DEL PROCESO");
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 24
        // Hacer un programa que permita calcular el area de un triangulo
        // cualquiera donde los valores de los lados son ingresados por
        // el teclado.
        // ---------------------------------------------------------------
        public static void Ejercicio24()
        {
            double ladoa, ladob, ladoc, sm, areatriangulo;
            Console.Write("ingrese lado A: ");
            ladoa = double.Parse(Console.ReadLine());
            Console.Write("ingrese lado B: ");
            ladob = double.Parse(Console.ReadLine());
            Console.Write("ingrese lado C: ");
            ladoc = double.Parse(Console.ReadLine());
            sm = (ladoa + ladob + ladoc) / 2;
            areatriangulo = Math.Round(Math.Pow(sm * (sm - ladoa) * sm * (sm - ladob) * sm * (sm - ladoc), 0.5), 2);
            Console.WriteLine("El area del triangulo es: " + areatriangulo);
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 25
        // Hacer un programa que calcule el valor de la hipotenusa de un
        // triangulo rectangulo, ingresando por el teclado sus catetos
        // (Teorema de Pitagoras).
        // ---------------------------------------------------------------
        public static void Ejercicio25()
        {
            double catetoa, catetob, hipotenusa;
            Console.Write("Ingrese primer cateto: ");
            catetoa = double.Parse(Console.ReadLine());
            Console.Write("Ingrese segundo cateto: ");
            catetob = double.Parse(Console.ReadLine());
            hipotenusa = Math.Round(Math.Pow(Math.Pow(catetoa, 2) + Math.Pow(catetob, 2), 0.5), 2);
            Console.WriteLine("");
            Console.WriteLine("La hipotenusa es: {0}", hipotenusa);
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 26
        // Hacer un programa que calcule la longitud de la circunferencia,
        // el area del circulo y el volumen de la esfera para un radio
        // ingresado por el teclado.
        // ---------------------------------------------------------------
        public static void Ejercicio26()
        {
            double pi, radio, area, volumen, longitud;
            pi = 3.14;
            Console.Write("Ingrese el radio de la circunferencia: ");
            radio = int.Parse(Console.ReadLine());
            longitud = 2 * pi * radio;
            area = Math.Round(pi * Math.Pow(radio, 2), 2);
            volumen = Math.Round((4 / 3) * pi * Math.Pow(radio, 3), 2);
            Console.WriteLine("");
            Console.WriteLine("Longitud de la circunferencia: " + longitud);
            Console.WriteLine("Area de la circunferencia: " + area);
            Console.WriteLine("Volumen de la circunferencia: " + volumen);
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 27
        // Calcular todos los pagos hechos de un restaurant que lea 130
        // consumos y que si el consumo ingresado excede los $130 el
        // descuento sera del 15%.
        // ---------------------------------------------------------------
        public static void Ejercicio27()
        {
            double consumo, descuento, total, c;
            c = 1;
            total = 0;
            do
            {
                c = c + 1;
                Console.Write("Ingrese {0}° consumo:  ", c - 1);
                consumo = double.Parse(Console.ReadLine());
                if (consumo > 130)
                {
                    descuento = consumo * 0.15;
                }
                else
                {
                    descuento = 0;
                }
                consumo = consumo - descuento;
                total = total + consumo;
            }
            while (c <= 130);
            Console.WriteLine("");
            Console.WriteLine("El total de los consumos es: " + total);
            Console.WriteLine("FIN DEL PROCESO");
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 28
        // Calcular la suma de los n primeros numeros enteros desde el
        // numero 8: S = 8 + 9 + 10 + 11 + ... + N
        // ---------------------------------------------------------------
        public static void Ejercicio28()
        {
            int numero, suma, x;
            suma = 0;
            Console.Write("Ingrese el numero enesimo:  ");
            numero = int.Parse(Console.ReadLine());
            if (numero < 8)
            {
                Console.WriteLine("");
                Console.WriteLine("Error el numero ingresado es menor a 8");
            }
            else
            {
                for (x = 8; x <= numero; x = x + 1)
                {
                    suma = suma + x;
                }
                Console.WriteLine("");
                Console.WriteLine("La suma de la serie de rango 8 hasta {0}, con un incremento de 1 es: {1}", numero, suma);
            }
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 29
        // La compañia Barner posee una caja con la cual empieza todos los
        // dias; diariamente se registran egresos. Calcular los egresos y
        // mostrar cuanto queda en caja. Termina al ingresar -1.
        // ---------------------------------------------------------------
        public static void Ejercicio29()
        {
            double caja, egreso, cont, totalegresos, restocaja;
            totalegresos = 0;
            caja = 371;
            cont = 0;
            do
            {
                cont = cont + 1;
                Console.Write("Ingrese {0} egreso: ", cont);
                egreso = double.Parse(Console.ReadLine());
                totalegresos = totalegresos + egreso;
                restocaja = caja - totalegresos;
            }
            while (egreso != -1);
            {
                Console.WriteLine("");
                Console.WriteLine("El total de egresos es: {0}", totalegresos + 1);
                Console.WriteLine("Lo sobrante en caja es: {0}", restocaja - 1);
                Console.ReadLine();
            }
        }

        // ---------------------------------------------------------------
        // Ejercicio 30
        // Diseñar un programa que permita ingresar dos notas y determine
        // su promedio, mostrando si esta aprobado o desaprobado.
        // ---------------------------------------------------------------
        public static void Ejercicio30()
        {
            double nota1, nota2, promedio;
            Console.Write("ingrese primera nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("ingrese seunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            promedio = (nota1 + nota2) / 2;
            if (nota1 >= 0 && nota1 <= 20 && nota2 >= 0 && nota2 <= 20)
            {
                if (promedio >= 10.5 && promedio <= 20)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Promedio: " + promedio);
                    Console.WriteLine("aprobado");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Promedio: " + promedio);
                    Console.WriteLine("desaprobado");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("EROR... Las notas ingresadas no se encuentran en la escala vigesimal (0-20)");
            }
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 31
        // Hacer un programa que clasifique personas segun el deporte que
        // practica: ajedrez, futbol, voley y basquet.
        // NOTA / DISCREPANCIA: el enunciado del PDF dice "400 personas",
        // pero el codigo original implementado usa un contador hasta 10.
        // Se preserva el codigo tal cual aparece en el documento.
        // ---------------------------------------------------------------
        public static void Ejercicio31()
        {
            string deporte;
            int vole, fut, aje, basq, c;
            vole = 0;
            fut = 0;
            aje = 0;
            basq = 0;
            c = 1;
            Console.WriteLine("LOS DEPORTES A INGRESAR PUEDEN SER FUTBOL, BASQUET, VOLEY Y AJEDREZ");
            do
            {
                c = c + 1;
                Console.Write("Ingrese deporte del {0}° alumno : ", c - 1);
                deporte = (Console.ReadLine());
                if (deporte == "voley")
                {
                    vole = vole + 1;
                }
                else if (deporte == "futbol")
                {
                    fut = fut + 1;
                }
                else if (deporte == "basquet")
                {
                    basq = basq + 1;
                }
                else if (deporte == "ajedrez")
                {
                    aje = aje + 1;
                }
                else
                {
                    Console.WriteLine("error deporte no valido");
                }
            }
            while (c <= 10);
            Console.WriteLine("");
            Console.WriteLine("cantidad de voley: " + vole);
            Console.WriteLine("cantidad de futbol: " + fut);
            Console.WriteLine("cantidad de basquet: " + basq);
            Console.WriteLine("cantidad de ajedrez: " + aje);
            Console.ReadLine();
        }

        // ---------------------------------------------------------------
        // Ejercicio 32
        // Braulio organiza una fiesta donde una computadora controla el
        // ingreso mediante 5 claves. Si alguna clave es incorrecta:
        // "TE EQUIVOCASTE DE FIESTA". Si las 5 son correctas:
        // "BIENVENIDO A LA FIESTA".
        // ---------------------------------------------------------------
        public static void Ejercicio32()
        {
            string c1, c2, c3, c4, c5;
            // la clave correcta es c1"tienes" c2"que ser" c3"invitado" c4"para" c5"ingresar"
            Console.Write("ingrese primera clave:  ");
            c1 = Console.ReadLine();
            if (c1 != "tienes")
                Console.WriteLine("TE EQUIVOCASTE DE FIESTA");
            else
            {
                Console.Write("ingrese segunda clave:  ");
                c2 = Console.ReadLine();
                if (c2 != "que ser")
                    Console.WriteLine("TE EQUIVOCASTE DE FIESTA");
                else
                {
                    Console.Write("ingrese tercera clave:  ");
                    c3 = Console.ReadLine();
                    if (c3 != "invitado")
                        Console.WriteLine("TE EQUIVOCASTE DE FIESTA");
                    else
                    {
                        Console.Write("ingrese cuarta clave:  ");
                        c4 = Console.ReadLine();
                        if (c4 != "para")
                            Console.WriteLine("TE EQUIVOCASTE DE FIESTA");
                        else
                        {
                            Console.Write("ingrese quinta clave:  ");
                            c5 = Console.ReadLine();
                            if (c5 != "ingresar")
                                Console.WriteLine("TE EQUIVOCASTE DE FIESTA");
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("BIENVENIDO A LA FIESTA");
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
