using System;

namespace SistemaVehiculos
{
    public class Auto : Vehiculo
    {
        public Auto(string marca, string modelo)
            : base(marca, modelo)
        {
        }

        public override void Encender()
        {
            Console.WriteLine($"El auto {Marca} {Modelo} está encendido.");
        }
    }
}