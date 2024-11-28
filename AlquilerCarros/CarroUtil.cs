using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    public class CarroUtil
    {
        public void CrearCarro(List<Carro> carros)
        {
            Console.WriteLine("\n****** Registro de Carros ******");
            Console.Write("Ingrese la placa del carro: ");
            string placa = Console.ReadLine();
            Console.Write("Ingrese la marca: ");
            string marca = Console.ReadLine();
            Console.Write("Ingrese el precio de alquiler: S/");
            double precioalquiler = double.Parse(Console.ReadLine());
            carros.Add(new Carro { Placa = placa, Marca = marca, PrecioAlquiler = precioalquiler });
            Console.Clear();
            Console.WriteLine("Carro registrado correctamente.\n\n");
        }
        public void ListarCarro(List<Carro> carros)
        {
            Console.Clear();
            if (carros.Count == 0)
            {
                Console.WriteLine("\nNo hay carros registrados\n\n");
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
        public void EliminarCarro(List<Carro> carros)
        {
            Console.Clear();
            if (carros.Count == 0)
            {
                Console.WriteLine("\nNo hay carros registrados.\n\n");
            }
            else if (carros.Count >= 1)
            {
                ListarCarro(carros);
                Console.Write("\nIngrese el índice del carro a eliminar: ");
                int index = int.Parse(Console.ReadLine());
                if (index >= 0 && index < carros.Count)
                {
                    carros.RemoveAt(index);
                    Console.WriteLine("Registro de carro eliminado con éxito.\n\n");
                }
                else
                {
                    Console.WriteLine("\nIndice invalido.\n\n");
                }
            }
        }
    }
}
