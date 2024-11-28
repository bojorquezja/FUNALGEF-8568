// See https://aka.ms/new-console-template for more information
using AlquilerCarros;
List<Carro> carros = new List<Carro>();
List<Cliente> clientes = new List<Cliente>();
List<Alquiler> alquileres = new List<Alquiler>();

while (true)
{
    Console.WriteLine("BIENVENIDO AL MENÚ PRINCIPAL\n");
    Console.WriteLine("************ MENÚ ************\n");
    Console.WriteLine(" 1.   Carros");
    Console.WriteLine(" 2.   Clientes");
    Console.WriteLine(" 3.   Alquileres");
    Console.WriteLine(" 0.   Salir");
    Console.WriteLine("\n******************************");
    Console.Write("Ingrese una opción: \n");
    int opc = int.Parse(Console.ReadLine());

    if (opc == 0)
    {
        Environment.Exit(0);
    }
    else if (opc == 1)
    {
        Console.Clear();
        Console.WriteLine("\n****** MENÚ DE CARROS ******\n");
        Console.WriteLine("1.   Registrar Carro");
        Console.WriteLine("2.   Listar Carros");
        Console.WriteLine("3.   Eliminar Registro de Carros");
        Console.WriteLine("0.   Salir");
        Console.WriteLine("\n******************************");
        Console.Write("Ingrese una opción: \n");
        opc = int.Parse(Console.ReadLine());

        switch (opc)
        {
            case 0: Environment.Exit(0); break;
            case 1:; break;
            case 2:; break;
            case 3:; break;
        }
    }
    else if (opc == 2) // OPCION: 2 | Servicios
    {
        Console.Clear();
        Console.WriteLine("\n ***** MENÚ DE CLIENTES *****\n");
        Console.WriteLine("1.   Registrar Cliente");
        Console.WriteLine("2.   Eliminar Cliente");
        Console.WriteLine("3.   Lista de Clientes");
        Console.WriteLine("0.   Salir");
        Console.WriteLine("\n******************************");
        Console.Write("Ingrese una opción: \n");
        opc = int.Parse(Console.ReadLine());

        switch (opc)
        {
            case 0: Environment.Exit(0); break;
            case 1: break;
            case 2: break;
            case 3: break;
        }
    }
    else if (opc == 3) // OPCION: 3 | Boleta
    {
        Console.Clear();
        Console.WriteLine("\n******* MENÚ DE ALQUILER *******\n");
        Console.WriteLine("1.   Registrar Alquiler");
        Console.WriteLine("2.   Lista de Alquileres");
        Console.WriteLine("3.   Carros a Alquilar");
        Console.WriteLine("0.   Salir");
        Console.WriteLine("\n******************************");
        Console.Write("Ingrese una opción: \n");
        opc = int.Parse(Console.ReadLine());

        switch (opc)
        {
            case 0: Environment.Exit(0); break;
            case 1:; break;
            case 2:; break;
        }
    }
}