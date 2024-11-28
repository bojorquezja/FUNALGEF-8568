using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlquilerCarros
{
    public class ClienteUtil
    {
        private static List<Cliente> clientes = new List<Cliente>();
        public void CrearCliente(List<Cliente> clientes)
        {
            Console.WriteLine("\n****** Registro de Clientes ******");
            Console.Write("Ingrese el DNI del ciente: ");
            int dni = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la marca: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el precio de alquiler: S/");
            double pagomaximo = double.Parse(Console.ReadLine());
            clientes.Add(new Cliente{ Dni = dni,Nombre = nombre, PagoMaximo = pagomaximo});
            Console.Clear();
            Console.WriteLine($"Cliente {nombre} creado con éxito.");
        }
        public void ListarCliente()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("No hay clientes en este sistema.");
                return;
            }
            Console.WriteLine("Listado de clientes: ");

            foreach (var cliente in clientes)
            {
                Console.WriteLine($"DNI: {cliente.Dni}, Nombre: {cliente.Nombre}, PagoMaximo: {cliente.PagoMaximo}");
            }
        }
        public void EliminarCliente(List<Cliente> clientes)
        {
            bool clienteEliminado = false;
            foreach (var cliente in clientes)
            {
                for (int i = 0; i < clientes.Count; i++)
                {
                    clientes.RemoveAt(i);
                    clienteEliminado = true;
                    Console.WriteLine($"Cliente con DNI {cliente.Dni} fue eliminado del sistema");
                    break;
                }
                if (clientes.Count == 0)
                {
                    Console.WriteLine($"No se encontró el cliente con el siguiente DNI {cliente.Dni}");
                }
            }
        }
    }
}
