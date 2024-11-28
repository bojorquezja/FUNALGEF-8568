using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlquilerCarros
{
    internal class ClienteUtil
    {
        public static void CrearCliente(Cliente[] clientes)
        {
            Console.WriteLine("Porfavor llene los siguientes datos a continuacion.");
            Console.Write("Numero de DNI: ");
            int dni = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese su pago maximo: ");
            double pagomaximo = double.Parse(Console.ReadLine());

            Cliente nuevocliente = new Cliente { Dni = dni, Nombre = nombre, PagoMaximo = pagomaximo };

        }
        public static void ListarClientes(Cliente[] clientes, int contador)
        {
            Console.WriteLine("===  Lista de Clientes  ===");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"* {i}. {clientes[i]} *");
            }
        }

        public static void EliminarCliente(Cliente[] cliente, ref int contador)
        {
            ListarClientes(cliente, contador);
            Console.Write("Seleccione el índice del cliente a eliminar: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < contador)
            {
                for (int i = index; i < contador - 1; i++)
                {
                    cliente[i] = cliente[i + 1];
                }
                cliente[--contador] = null;
                Console.WriteLine("Cliente eliminado con éxito...");
            }
            else
            {
                Console.WriteLine("Índice inválido..");
            }
        }

    }
}
