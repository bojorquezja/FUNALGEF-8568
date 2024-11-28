using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    public class Alquiler
    {
        public int Numero { get; set; }
        public Carro CarroAlq { get; set; }
        public Cliente Contratante { get; set; }
        public double Precio { get; set; }
        public override string? ToString()
        {
            return $"Numero: {Numero}\nCarro: {CarroAlq}\nCliente: {Contratante}\nPrecio :{Precio}";
        }
    }
}
