public static class ClienteUtil
{
    private static Cliente[] clientes = new Cliente[100]; // Limite de 100 clientes
    private static int count = 0; // Para llevar la cuenta de cuántos clientes hay

    public static void Crear(Cliente cliente)
    {
        if (count < clientes.Length)
        {
            clientes[count] = cliente;
            count++;
        }
        else
        {
            Console.WriteLine("No se pueden agregar más clientes.");
        }
    }
    public static void Listar()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(clientes[i]);
        }
    }
    public static void Eliminar(int dni)
    {
        for (int i = 0; i < count; i++)
        {
            if (clientes[i].Dni == dni)
            {
                // Desplazar los elementos hacia la izquierda
                for (int j = i; j < count - 1; j++)
                {
                    clientes[j] = clientes[j + 1];
                }
                clientes[count - 1] = null; // Eliminar el último elemento
                count--;
                Console.WriteLine($"Cliente con DNI {dni} eliminado.");
                return;
            }
        }
        Console.WriteLine("Cliente no encontrado.");
    }
}


