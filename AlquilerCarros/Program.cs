// See https://aka.ms/new-console-template for more information
using AlquilerCarros;
List<Carro> carros = new List<Carro>(100);
List<Cliente> clientes = new List<Cliente>(100);
List<Alquiler> alquileres = new List<Alquiler>(100);

CarroUtil c = new CarroUtil();
ClienteUtil cl = new ClienteUtil();
AlquilerUtil a = new AlquilerUtil();

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
            case 1:c.CrearCarro(carros); break;
            case 2:c.ListarCarro(carros); break;
            case 3:c.EliminarCarro(carros); break;
        }
    }
    else if (opc == 2)
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
                /* case 1: cl.CrearCliente(clientes); break;
                 case 2: cl.EliminarCliente(clientes); break;
                 case 3: cl.ListarCliente(clientes); break; */
             }
         }
         else if (opc == 3)
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
                /* case 1: a.CrearAlquiler(); break;
                 case 2: a.ListarAlquiler(); break;
                 case 3: a.CarrosAlquiler(); break; */
        }
    }
}