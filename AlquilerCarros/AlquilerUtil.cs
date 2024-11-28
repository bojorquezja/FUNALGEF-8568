using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    public class AlquilerUtil
    {
        public static int n_alq = 0;
        public static void Crear()
        {
            Alquiler a_n = new Alquiler();
            Console.WriteLine("Alquiler crado correctamente");
            Console.Write("Numero de orden: ");
            n_alq++;
            a_n.Numero = n_alq;
            Console.Write("Carro a alquilar: ");

            Console.WriteLine("Alquiler crado correctamente");

        }
        public static void Listar()
        {
            Console.WriteLine(" ");
        }
        public static void CarrosAAlquilar()
        {
            Console.WriteLine(" ");
        }
    }
}
