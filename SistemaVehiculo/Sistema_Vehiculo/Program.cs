using System;
using System.Collections.Generic;

namespace SistemaVehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Conductor conductor = new Conductor();

            conductor.Nombre = "Miguel";
            conductor.Edad = 18;

            Console.WriteLine("Conductor: " + conductor.Nombre);
            Console.WriteLine("Edad: " + conductor.Edad);

            List<Vehiculo> vehiculos = new List<Vehiculo>();

            vehiculos.Add(new Auto("ferrari", "SF90"));
            vehiculos.Add(new Moto("ninja", "300"));

            foreach (Vehiculo v in vehiculos)
            {
                v.Encender();
            }

            Console.ReadKey();
        }
    }
}