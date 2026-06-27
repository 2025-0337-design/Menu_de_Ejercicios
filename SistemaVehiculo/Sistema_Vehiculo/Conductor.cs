using System;

namespace SistemaVehiculos
{
    public class Conductor
    {
        private int edad;

        public string Nombre { get; set; }

        public int Edad
        {
            get { return edad; }
            set
            {
                if (value >= 18)
                    edad = value;
                else
                    Console.WriteLine("La edad debe ser mayor o igual a 18.");
            }
        }
    }
}