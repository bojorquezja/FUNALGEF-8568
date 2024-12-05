public class Alquiler
{
    public int Numero { get; set; }
    public Carro CarroAlq { get; set; }
    public Cliente Contratante { get; set; }
    public double Precio { get; set; }

    public override string ToString()
    {
        return $"Número: {Numero}, {CarroAlq}, {Contratante}, Precio: {Precio:C}";
    }
}
