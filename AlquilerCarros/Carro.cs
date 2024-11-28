using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    public class Carro
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public double PrecioAlquiler { get; set; }

        public override string ToString() => $"Placa: {Placa}, Marca: {Marca}, Precio del Alquiler: {PrecioAlquiler}";

        public static Carro CrearCarrro()
        {
            Console.Write("Ingrese el numero de la placa: ");
            string placa = Console.ReadLine();
            Console.WriteLine("Ingrese la marca del vehiculo: ");
            string marca = Console.ReadLine();
            Console.WriteLine("Ingrese el monto del alquiler");
            double precioalquiler = double.Parse(Console.ReadLine());

            return new Carro { Placa = placa, Marca = marca, PrecioAlquiler = precioalquiler };
        }

       
    }
}
