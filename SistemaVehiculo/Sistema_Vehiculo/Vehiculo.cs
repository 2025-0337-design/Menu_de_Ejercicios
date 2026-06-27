using System;

namespace SistemaVehiculos
{
    public abstract class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public abstract void Encender();
    }
}
