using AlquilerCarros;
//Chumbiauca Quispe , Maria Fernando
//Alarcon Pinao , Andre Adolfo
//Garcia Osorio , James Hgun Jair
//Casas Olivos , Fabian Alexandro
/*
CarroUtil cu = new CarroUtil();

Console.WriteLine("MENÚ:");
Console.WriteLine("1. Carro");
Console.WriteLine("2. Cliente");
Console.WriteLine("3. Alquiler");
Console.WriteLine("4. Elimina: elimina un desayuno");
Console.WriteLine("0. Salir");
Console.Write("Seleccione una opción: ");
int valor = int.Parse(Console.ReadLine());

switch (valor)
{
    case 1: cu.Crear(); break;
    case 2: cu.Listar() break;
    case 3: cu.Eliminar() break;
}
*/


int[]arr = new int[2];
int menu_number, menu_number_carro, array_length = 0, array2_length = 0, elim = 0;
string[] desayuno = new string[array_length];
CarroUtil carro_u = new CarroUtil(); 
AlquilerUtil au  = new AlquilerUtil();
Clienteutil cu = new Clienteutil();
do
{
    do
    {
        Console.Clear();
        Console.WriteLine("MENÚ:");
        Console.WriteLine("1. Carro");
        Console.WriteLine("2. Cliente");
        Console.WriteLine("3. Alquiler");
        Console.WriteLine("0. Salir");
        Console.Write("Seleccione una opción: ");
        string valor = Console.ReadLine();
        if (int.TryParse(valor, out menu_number)) ;
    } while (false);
    switch (menu_number)
    {
        case 1:
            do
            {
                Console.Clear();
                Console.WriteLine("MENÚ:");
                Console.WriteLine("1. Crear Carro");
                Console.WriteLine("2. Listar Carros");
                Console.WriteLine("3. Eliminar Carro");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                string valor = Console.ReadLine();
                if (int.TryParse(valor, out menu_number_carro)) ;
            } while (false);
            switch(menu_number_carro)
                { 
                case 1:
                    Console.Clear();
                    carro_u.Crear();
                    break;
                case 2:
                    carro_u.Listar();
                    break;
                case 3:
                    carro_u.Eliminar();
                    break ; 
                case 0:
                    Console.Clear(); 
                    break;
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Error. Valor no válido");
                        Console.WriteLine("");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                    }
                }

           
            break;
        case 2:
            do
            {
                Console.Clear();
                Console.WriteLine("MENÚ:");
                Console.WriteLine("1. Crear Cliente");
                Console.WriteLine("2. Listar Cliente");
                Console.WriteLine("3. Eliminar Cliente");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                string valor = Console.ReadLine();
                if (int.TryParse(valor, out menu_number_carro)) ;
            } while (false);
            switch (menu_number_carro)
            {
                case 1:
                    Console.Clear();
                    cu.Crear();
                    break;
                case 2:
                    cu.Listar(); break;
                case 3:
                    cu.Eliminar();                break;
                case 0:
                    Console.Clear();
                    break;
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Error. Valor no válido");
                        Console.WriteLine("");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                    }
            }
            break;
        case 3:
            do
            {
                Console.Clear();
                Console.WriteLine("MENÚ:");
                Console.WriteLine("1. Crear Cliente");
                Console.WriteLine("2. Listar Cliente");
                Console.WriteLine("3. Eliminar Cliente");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                string valor = Console.ReadLine();
                if (int.TryParse(valor, out menu_number_carro)) ;
            } while (false);
            switch (menu_number_carro)
            {
                case 1:
                    Console.Clear();                    au.Crear();
                    break;
                case 2:
                    au.Listar(); break;
                case 3:
                    au.Eliminar(); break ;
                case 0:
                    Console.Clear();
                    break;
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Error. Valor no válido");
                        Console.WriteLine("");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                    }
            }
            break;
       
        case 0:
            Console.Clear();
            Console.WriteLine("Terminó el programa");
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            break;
        default:
            Console.Clear();
            Console.WriteLine("Error. Valor no válido ultimo");
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            break;
    }
} while (menu_number != 0);
