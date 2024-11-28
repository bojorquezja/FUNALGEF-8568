using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    internal class Claseutil
    {
        public void crear1()

        {

            Carro carro = new Carro();



            Console.WriteLine("Ingrese la placa:");

            carro.Placa = Console.ReadLine();

            Console.WriteLine("Ingrese la marca del carro:");

            carro.Marca = Console.ReadLine();

            Console.WriteLine("Ingrese el preci");

            carro.PrecioAlquiler = double.Parse(Console.ReadLine());

        }

        public void crear2()

        {

            Cliente cliente = new Cliente();



            Console.WriteLine("Ingrese el dni del cliente:");

            cliente.Dni = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese le nombre del cliente:");

            cliente.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese pago maximo:");

            cliente.PagoMaximo = double.Parse(Console.ReadLine());

        }

        public void crear3()

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

        public void eliminar1()

        {



        }

        public void eliminar2()

        {



        }

        public void eliminar3()

        {



        }
    }
}
