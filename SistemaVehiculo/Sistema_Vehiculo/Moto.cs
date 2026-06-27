using System;

namespace SistemaVehiculos
{
    public class Moto : Vehiculo
    {
        public Moto(string marca, string modelo)
            : base(marca, modelo)
        {
        }

        public override void Encender()
        {
            Console.WriteLine($"La moto {Marca} {Modelo} está encendida.");
        }
    }
}
