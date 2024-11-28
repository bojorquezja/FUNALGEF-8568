using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    public class CarroUtil
    {
        public static void CrearCarro()
        {
            if ( )
            {

            }
            else
            {
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
        }
        public static void ListarCarro()
        {

        }
        public static void EliminarCarro()
        {

        }
    }
}
