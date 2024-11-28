using AlquilerCarros;

int opc = 0;
Carro[] carro = new Carro[10];
Cliente[] cliente = new Cliente[10];
Alquiler[] alquiler = new Alquiler[10];
int carroCount = 0, clienteCount = 0, alquilerCount = 0;
do
{
    Console.WriteLine("\n");
    Console.WriteLine("*****************************************");
    Console.WriteLine("1- Crear Carro");
    Console.WriteLine("2- Listar Carros");
    Console.WriteLine("3- Eliminar Carro");
    Console.WriteLine("4- Crear Cliente");
    Console.WriteLine("5- Listar Clientes");
    Console.WriteLine("6- Eliminar Cliente");
    Console.WriteLine("7- Crear Alquiler");
    Console.WriteLine("8- Listar Alquileres");
    Console.WriteLine("9- Carro a alquilar");
    Console.WriteLine("0- Salir");
    Console.WriteLine("*****************************************");
    Console.WriteLine("\n");
    Console.WriteLine("Ingrese que opcion desea ingresar primero: ");
    Console.ResetColor();
    Console.WriteLine("Ingrese la opcion: ");
    opc = int.Parse(Console.ReadLine());
    switch (opc)
    {
    }
        case 1:
        if (carroCount < carro.Length)
        {
            carro[carroCount++] = CarroUtil.CrearCarrro();
        }
        break;
    case 2:
        CarroUtil.ListarCarro(carro, carroCount);
        break;
    case 3:
        CarroUtil.EliminarCarro(carro, ref carroCount);
        break;
    case 4:
        if (clienteCount < cliente.Length)
        {
            cliente[clienteCount++] = ClienteUtil.CrearCliente(cliente,ref clienteCount);
        }
        break;
    case 5:
        ClienteUtil.ListarClientes(cliente, clienteCount);
        break;
    case 6:
        ClienteUtil.EliminarCliente(cliente, ref clienteCount);
        break;
    case 7:
        if (alquilerCount < alquiler.Length)
        {
            alquiler[alquilerCount++] = Alquiler.CrearAlquiler();
        }
        break;
    case 8:
        AlquilerUtil.ListarAlquiler();
        break;
    case 9:
        AlquilerUtil.CarrosaAlquilar();
        break;
    case 0:
        Console.WriteLine("Cerrando Programa..."),
        break;
    } while (opc != 0)