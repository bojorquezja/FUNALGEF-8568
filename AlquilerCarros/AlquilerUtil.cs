using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    internal class AlquilerUtil
    {


        public static void alquilerutil()
        {
            Alquiler alquiler = new Alquiler();
            Console.WriteLine("Ingrese el numero de placa:");
            alquiler.Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el carro:");
            alquiler.Carro = Console.ReadLine();
            Console.WriteLine("ingrese el contratante");
            alquiler.Cliente = Console.ReadLine();
            Console.WriteLine("Ingrese el precio:");
            alquiler.Precio = double.Parse(Console.ReadLine());
        }
    }
}

