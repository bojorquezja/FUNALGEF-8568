public static class AlquilerUtil
{
    private static Alquiler[] alquileres = new Alquiler[100]; // Limite de 100 alquileres
    private static int count = 0; // Para llevar la cuenta de cuántos alquileres hay

    // Método para devolver el arreglo de alquileres
    public static Alquiler[] GetAlquileres()
    {
        return alquileres;
    }

    // Método para devolver el número de alquileres en el arreglo
    public static int GetCount()
    {
        return count;
    }

    // Método para agregar un alquiler
    public static void Crear(Alquiler alquiler)
    {
        if (count < alquileres.Length)
        {
            alquileres[count] = alquiler;
            count++;
        }
        else
        {
            Console.WriteLine("No se pueden agregar más alquileres.");
        }
    }

    // Método para listar todos los alquileres
    public static void Listar()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(alquileres[i]);
        }
    }
    // Método para mostrar los carros disponibles para alquilar de acuerdo con el pago máximo del cliente
    public static void CarrosAAlquilar(int dniCliente)
    {
        // Buscar el cliente
        Cliente cliente = null;
        for (int i = 0; i < ClienteUtil.GetCount(); i++)
        {
            if (ClienteUtil.GetClientes()[i].Dni == dniCliente)
            {
                cliente = ClienteUtil.GetClientes()[i];
                break; // Detener la búsqueda si se encuentra el cliente
            }
        }

        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado.");
            return;
        }

        // Mostrar los carros cuyo precio de alquiler sea menor o igual al pago máximo del cliente
        Console.WriteLine($"Carros disponibles para el cliente {cliente.Nombre} (DNI: {cliente.Dni}):");
        bool encontrado = false;
        for (int i = 0; i < CarroUtil.GetCount(); i++)
        {
            if (CarroUtil.GetCarros()[i].PrecioAlquiler <= cliente.PagoMaximo)
            {
                Console.WriteLine(CarroUtil.GetCarros()[i]);
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("No hay carros disponibles dentro del rango de precio del cliente.");
        }
    }
}
