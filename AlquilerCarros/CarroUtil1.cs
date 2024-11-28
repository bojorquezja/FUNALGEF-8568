using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    internal class CarroUtil1
    {
        Claseutil util = new Claseutil();

        public void Opcion1()

        {

            byte opcion1;

            do



            {







                Console.WriteLine("\n**MENU**");



                Console.WriteLine("Crear [1]: ");

                Console.WriteLine("Listar [2]: ");

                Console.WriteLine("FIN [0]: ");



                Console.WriteLine("Ingrese opcion: ");



                while (!byte.TryParse(Console.ReadLine(), out opcion1) || opcion1 > 2)



                {



                    Console.WriteLine("Error: Ingrese valor: ");



                }



                Console.Clear();



                switch (opcion1)

                {

                    case 1:

                        util.crear1(); break;



                }

            } while (opcion1 != 0);



        }
    }
}