using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    public class CarroUtil
    {
        public static void CrearCarro(List<Carro> carros)
        {
            Console.WriteLine("****** Registro de Carros ******");
            Console.Write("Ingrese la placa del carro: ");
            string placa = Console.ReadLine();
            Console.Write("Ingrese la marca: ");
            string marca = Console.ReadLine();
            Console.Write("Ingrese el precio de alquiler: ");
            double precioalquiler = double.Parse(Console.ReadLine());
            carros.Add(new Carro { Placa = placa, Marca = marca, PrecioAlquiler = precioalquiler });
            Console.Clear();
            Console.WriteLine("Carro registrado correctamente.\n\n");
        }
        public static void ListarCarro(List<Carro> carros)
        {
            Console.Clear();
            if (carros.Count == 0)
            {
                Console.WriteLine("No hay carros registrados");
            }
            else
            {
                Console.WriteLine("****** Lista de Carros ******");
                for (int i = 0; i < carros.Count; i++)
                {
                    Console.WriteLine($"{i}: {carros}");
                }
            }
        }
        public static void EliminarCarro(List<Carro> carros)
        {
            Console.Clear();
            int index = int.Parse(Console.ReadLine());
            if (index >= 0 && index < carros.Count)
            {
                carros.RemoveAt(index);
                Console.WriteLine("Registro de carro eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("Indice invalido.");
            }
        }
    }
}
