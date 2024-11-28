public class Program

{
    static CarroUtil[] carros = new CarroUtil[10];

    static ClienteUtil[] clientes = new ClienteUtil[5];

    static AlquilerUtil[] alquileres = new AlquilerUtil[10];

    public static void Main()

    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("Bienvenido a la Veterinaria. Selecciona una opción:");
            Console.WriteLine("1. Crear Carro");
            Console.WriteLine("2. Eliminar Carro");
            Console.WriteLine("3. Listar Carro");
            Console.WriteLine("4. Crear Cliente");
            Console.WriteLine("5. Eliminar Cliente");
            Console.WriteLine("6. Listar Cliente");
            Console.WriteLine("7. Crear Alquiler");
            Console.WriteLine("8. Listar Alquiler");
            Console.WriteLine("9. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:

                    CarroUtil.CrearCarro(carros);

                    break;

                case 2:

                    CarroUtil.EliminarCarro(carros);

                    break;

                case 3:

                    CarroUtil.ListarCarro(carros);

                    break;

                case 4:

                    ClienteUtil.CrearCliente(clientes);

                    break;

                case 5:

                    ClienteUtil.EliminarCliente(clientes);

                    break;

                case 6:

                    ClienteUtil.ListarCliente(clientes);

                    break;

                case 7:

                    AlquilerUtil.CrearAlquiler(alquileres, carros, clientes);

                    break;

                case 8:

                    AlquilerUtil.ListarAlquiler(alquileres);

                    break;

                case 9:

                    Console.WriteLine("¡Hasta pronto!");

                    break;

                default:

                    Console.WriteLine("Opción no válida.");

                    break;

            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        } while (opcion != 9);
    }
}