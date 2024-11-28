using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    internal class CarroUtil1
    {
        public static void carroutil()
        {
            Carro carro = new Carro();

            Console.WriteLine("Ingrese la placa:");
            carro.Placa = Console.ReadLine();
            Console.WriteLine("Ingrese la marca del carro:");
            carro.Marca = Console.ReadLine();
            Console.WriteLine("Ingrese el preci");
            carro.PrecioAlquiler=double.Parse(Console.ReadLine());
        }
    }
}
