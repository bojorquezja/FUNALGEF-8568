using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        // Menú de opciones
        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Crear Carro");
            Console.WriteLine("2. Listar Carros");
            Console.WriteLine("3. Eliminar Carro");
            Console.WriteLine("4. Crear Cliente");
            Console.WriteLine("5. Listar Clientes");
            Console.WriteLine("6. Eliminar Cliente");
            Console.WriteLine("7. Crear Alquiler");
            Console.WriteLine("8. Listar Alquileres");
            Console.WriteLine("9. Ver Carros a Alquilar");
            Console.WriteLine("0. Salir");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // Crear Carro
                    Console.Write("Placa: ");
                    string placa = Console.ReadLine();
                    Console.Write("Marca: ");
                    string marca = Console.ReadLine();
                    Console.Write("Precio Alquiler: ");
                    double precioAlquiler = double.Parse(Console.ReadLine());
                    CarroUtil.Crear(new Carro { Placa = placa, Marca = marca, PrecioAlquiler = precioAlquiler });
                    break;
                case 2:
                    // Listar Carros
                    CarroUtil.Listar();
                    break;
                case 3:
                    // Eliminar Carro
                    Console.Write("Ingrese la placa del carro a eliminar: ");
                    string placaEliminar = Console.ReadLine();
                    CarroUtil.Eliminar(placaEliminar);
                    break;
                case 4:
                    // Crear Cliente
                    Console.Write("DNI: ");
                    int dni = int.Parse(Console.ReadLine());
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Pago Máximo: ");
                    double pagoMaximo = double.Parse(Console.ReadLine());
                    ClienteUtil.Crear(new Cliente { Dni = dni, Nombre = nombre, PagoMaximo = pagoMaximo });
                    break;
                case 5:
                    // Listar Clientes
                    ClienteUtil.Listar();
                    break;
                case 6:
                    // Eliminar Cliente
                    Console.Write("Ingrese el DNI del cliente a eliminar: ");
                    int dniEliminar = int.Parse(Console.ReadLine());
                    ClienteUtil.Eliminar(dniEliminar);
                    break;
                case 7:
                    // Crear Alquiler
                    Console.Write("Número de alquiler: ");
                    int numero = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el DNI del cliente: ");
                    int dniCliente = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la placa del carro: ");
                    string placaCarro = Console.ReadLine();

                    // Buscar el cliente manualmente
                    Cliente cliente = null;
                    for (int i = 0; i < ClienteUtil.GetCount(); i++)
                    {
                        if (ClienteUtil.GetClientes()[i].Dni == dniCliente)
                        {
                            cliente = ClienteUtil.GetClientes()[i];
                            break; // Salir del bucle cuando encontramos el cliente
                        }
                    }

                    // Buscar el carro manualmente
                    Carro carro = null;
                    for (int i = 0; i < CarroUtil.GetCount(); i++)
                    {
                        if (CarroUtil.GetCarros()[i].Placa == placaCarro)
                        {
                            carro = CarroUtil.GetCarros()[i];
                            break; // Salir del bucle cuando encontramos el carro
                        }
                    }

                    if (cliente != null && carro != null)
                    {
                        AlquilerUtil.Crear(new Alquiler
                        {
                            Numero = numero,
                            CarroAlq = carro,
                            Contratante = cliente,
                            Precio = carro.PrecioAlquiler
                        });
                    }
                    else
                    {
                        Console.WriteLine("Cliente o carro no encontrado.");
                    }
                    break;

                case 8:
                    // Listar Alquileres
                    AlquilerUtil.Listar();
                    break;
                case 9:
                    // Ver Carros a Alquilar
                    Console.Write("Ingrese el DNI del cliente: ");
                    int dniClienteAlquiler = int.Parse(Console.ReadLine());
                    AlquilerUtil.CarrosAAlquilar(dniClienteAlquiler);
                    break;
                case 0:
                    // Salir
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
