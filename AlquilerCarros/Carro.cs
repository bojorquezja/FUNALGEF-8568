public class Carro
{
    public string Placa { get; set; }
    public string Marca { get; set; }
    public double PrecioAlquiler { get; set; }

    public override string ToString()
    {
        return $"Placa: {Placa}, Marca: {Marca}, Precio de Alquiler: {PrecioAlquiler:C}";
    }
}
