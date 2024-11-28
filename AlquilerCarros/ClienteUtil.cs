using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    public class Clienteutil

    {

        private static Cliente[] clientes = new Cliente[10];



        private static int contador = 0;

        public static void Crear()

        {

            if (contador >= clientes.Length)

            {

                Console.WriteLine("No se pueden agregar más clientes, el arreglo está lleno.");

                return;

            }

            Cliente c = new Cliente();

            Console.WriteLine("Ingrese DNI del cliente: ");

            c.Dni = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese nombre del cliente: ");

            c.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese pago máximo: ");

            c.PagoMaximo = double.Parse(Console.ReadLine());

            clientes[contador] = c;

            contador++;

            Console.WriteLine("Cliente creado exitosamente.");

        }

        public static void Listar()

        {

            if (contador == 0)

            {

                Console.WriteLine("No hay clientes registrados.");



                return;

            }

            for (int i = 0; i < contador; i++)

            {

                Console.WriteLine(clientes[i].ToString());

            }

        }

        public static void Eliminar()

        {

            if (contador == 0)

            {

                Console.WriteLine("No hay clientes para eliminar.");

                return;

            }

            Console.WriteLine("Ingrese el DNI del cliente a eliminar:");

            int dni = int.Parse(Console.ReadLine());

            bool encontrado = false;

            for (int i = 0; i < contador; i++)

            {

                if (clientes[i].Dni == dni)

                {

                    for (int j = i; j < contador - 1; j++)

                    {

                        clientes[j] = clientes[j + 1];

                    }

                    clientes[contador - 1] = null;

                    contador--;

                    Console.WriteLine("Cliente eliminado exitosamente.");

                    encontrado = true;

                    break;

                }

            }

            if (!encontrado)

            {

                Console.WriteLine("Cliente no encontrado.");

            }

        }

    }

}

