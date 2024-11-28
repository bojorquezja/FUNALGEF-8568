public class Cliente
{
    public int Dni { get; set; }
    public string Nombre { get; set; }
    public double PagoMaximo { get; set; }

    public override string ToString()
    {
        return $"DNI: {Dni}, Nombre: {Nombre}, Pago Máximo: {PagoMaximo:C}";
    }
}
