using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    public static class Carro_Util
    {
        private static Carro[] carros = new Carro[100]; //Limite de carros
        private static int count = 0; //Para llevar la cuenta de cuantos autos hay
        public static void Crear(Carro carro)
        {
            if (count < carros.Length)
            {
                carros[count] = carro;
                count++;
            }
            else
            {
                Console.WriteLine("No se pueden agregar más carros.");
            }
        }
        public static void Listar()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(carros[i]);
            }
        } 

    }
}
