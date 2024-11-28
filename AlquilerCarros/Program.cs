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
do
{
    do
    {
        Console.Clear();
        Console.WriteLine("MENÚ:");
        Console.WriteLine("1. Carro");
        Console.WriteLine("2. Cliente");
        Console.WriteLine("3. Alquiler");
        Console.WriteLine("4. Elimina: elimina un desayuno");
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
                case 3:
                    carro_u.Eliminar();
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

            Console.WriteLine("Lista de desayunos creada");
            Console.WriteLine("Inserte la cantidad de desayunos que desea para su lista:");
            array_length = int.Parse(Console.ReadLine());
            Array.Resize(ref desayuno, array_length);
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            break;
        case 2:
            Console.Clear();
            for (int i = 0; i < desayuno.Length; i++)
            {
                Console.WriteLine($"Inserte qué valores quiere almacenar en el {i + 1}° espacio:");
                desayuno[i] = Console.ReadLine();
            }
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Aquí se muestran los valores ingresados con su ubicación:");
            for (int i = 0; i < desayuno.Length; i++)
            {
                Console.WriteLine($"Ubicación: {i} --> Valor: {desayuno[i]}");
            }
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            break;
        case 4:

            Console.Clear();
            Console.WriteLine("¿Qué elemento desea eliminar?");
            Console.Write("Inserte el nombre del desayuno: ");
            string nombre_desayuno = Console.ReadLine();
            if (Array.Exists(desayuno, element => element == nombre_desayuno))
            {
                elim = Array.IndexOf(desayuno, nombre_desayuno);
                string[] desayuno2 = new string[array_length];//creacion de array 
                desayuno2 = desayuno;
                array2_length = array_length - 1;
                Array.Resize(ref desayuno, array2_length);
                for (int i = 0, i2 = 0; i2 < desayuno2.Length; i2++)
                {
                    if (i2 != elim)
                    {
                        desayuno[i] = desayuno2[i2];
                        i++;
                    }
                    else { }
                }
                        array_length = array2_length;
                Console.WriteLine($"Se eliminó la posición {elim}, es decir el {elim + 1}° elemento");
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Elemento no encontrado");
                Console.WriteLine("");
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();
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
