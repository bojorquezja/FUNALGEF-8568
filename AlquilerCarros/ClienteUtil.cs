using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    internal class ClienteUtil
    {
        public static void clienteutil()
        {
           Cliente cliente = new Cliente();

            Console.WriteLine("Ingrese el dni del cliente:");
            cliente.Dni=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese le nombre del cliente:");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese pago maximo:");
            cliente.PagoMaximo=double.Parse(Console.ReadLine());
        }
    }
}
