using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    public class CarroUtil
    {
        private static Carro[] carros = new Carro[100];
        private static int contador = 0;

        public static void Crear()
        {

            if (contador >= carros.Length)
            {
                Console.WriteLine("No se pueden agregar más carros, el arreglo está lleno.");
                return;
            }

            Carro c = new Carro();

            Console.WriteLine("Ingrese precio de alquiler: ");
            c.PrecioAlquiler = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese numero de placa: ");
            c.Placa = Console.ReadLine();

            Console.WriteLine("Ingrese marca: ");
            c.Marca = Console.ReadLine();


            carros[contador] = c;
            contador++;
            Console.WriteLine("Carro creado exitosamente.");
        }

        public static void Listar()
        {
            if (contador == 0)
            {
                Console.WriteLine("No hay carros registrados.");
                return;
            }

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(carros[i].ToString());
            }
        }

        public static void Eliminar()
        {
            if (contador == 0)
            {
                Console.WriteLine("No hay carros para eliminar.");
                return;
            }

            Console.WriteLine("Ingrese la placa del carro a eliminar:");
            string placa = Console.ReadLine();

            bool encontrado = false;

            for (int i = 0; i < contador; i++)
            {
                if (carros[i].Placa == placa)
                {

                    for (int j = i; j < contador - 1; j++)
                    {
                        carros[j] = carros[j + 1];
                    }


                    carros[contador - 1] = null;


                    contador--;
                    Console.WriteLine("Carro eliminado exitosamente.");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Carro no encontrado.");
            }

        }
    }




}
