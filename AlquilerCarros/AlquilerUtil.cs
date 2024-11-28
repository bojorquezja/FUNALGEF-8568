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

