using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    public class Carro
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public double PrecioAlquiler {  get; set; }
        public override string ToString()
        {
            return "Hola carro";
        }
    }
}
