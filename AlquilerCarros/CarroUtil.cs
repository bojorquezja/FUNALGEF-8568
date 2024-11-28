using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    internal class CarroUtil
    {
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

        public static void ListarCarro(Carro[] carro, int count)
        {
            Console.WriteLine("===Lista de Carros===");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i}. {carro[i]}");
            }
        }

        public static void EliminarCarro(Carro[] carro, ref int count)
        {
            ListarCarro(carro, count);
            Console.Write("Seleccione el indice del carro a eliminar: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < count)
            {
                for (int i = index; i < count - 1; i++)
                {
                    carro[i] = carro[i + 1];
                }
                carro[--count] = null;
                Console.WriteLine("Carro eliminado con exito.");
            }
            else
            {
                Console.WriteLine("Indice invalido..");
            }

        }
    }
}
