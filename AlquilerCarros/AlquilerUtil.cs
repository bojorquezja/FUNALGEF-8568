using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlquilerCarros
{
    internal class AlquilerUtil
    {
        public static void CrearAlquiler(Alquiler[] alquileres, ref int count)
        {
            Console.WriteLine("Porfavor llene los siguientes datos a continuacion:");
            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Carro de Alquiler: ");
            int CarroAlq = int.Parse(Console.ReadLine());
            Console.Write("Contratante: ");
            string Contratante = Console.ReadLine();
            Console.Write("Precio: ");
            string Precio = Console.ReadLine();

            return new Alquiler { Numero, CarroAlq, Contratante, Precio };
            count++;


        }
        public static void ListarAlquiler(Alquiler[] alquileres, int count)
        {
            Console.WriteLine("===Listado de Alquiler===");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(($"{i}.{alquileres[i].ToString()}"));
            }
        }

        public static void CarrosaAlquilar(Cliente[] cliente, Carro[] Carro, Carro.PrecioAlquiler, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Carro[] carrolist = new Carro[];
                if (Carro.PrecioAlquiler <= PagoMaximo)
                {
                    carrolist[i] = Carro[i];
                }
            }
        }
    }
}
