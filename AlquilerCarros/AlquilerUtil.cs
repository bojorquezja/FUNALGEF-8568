public class AlquilerUtil
{
    public string Codigo { get; set; }
    public Cliente Cliente { get; set; }
    public Carro Carro { get; set; }
    public decimal Total { get; set; }

    public AlquilerUtil(string codigo, Cliente cliente, Carro carro)
    {
        Codigo = codigo;
        Cliente = cliente;
        Carro = carro;
        Total = carro.PrecioAlquiler;
    }

    public override string ToString()
    {
        return $"Código: {Codigo}, Cliente: {Cliente.Nombre}, Carro: {Carro.Modelo}, Total: {Total}";
    }
}

public static class AlquilerUtil
{
    private static List<Alquiler> alquileres = new List<Alquiler>();

    public static void CrearAlquiler(AlquilerUtil[] alquileres, Carro[] carros, Cliente[] clientes)
    {
        Console.WriteLine("Seleccione el cliente para el alquiler:");
        ClienteUtil.ListarCliente(clientes);
        int clienteIndex = int.Parse(Console.ReadLine()) - 1;

        Console.WriteLine("Seleccione el carro para el alquiler:");
        CarroUtil.ListarCarro(carros);
        int carroIndex = int.Parse(Console.ReadLine()) - 1;

        string codigoAlquiler = Guid.NewGuid().ToString();
        Alquiler nuevoAlquiler = new Alquiler(codigoAlquiler, clientes[clienteIndex], carros[carroIndex]);

        for (int i = 0; i < alquileres.Length; i++)
        {
            if (alquileres[i] == null)
            {
                alquileres[i] = nuevoAlquiler;
                Console.WriteLine($"Alquiler creado con código: {codigoAlquiler}");
                return;
            }
        }

        Console.WriteLine("No hay espacio para más alquileres.");
    }

