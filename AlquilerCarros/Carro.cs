using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    internal class Carro
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public double PrecioAlquiler { get; set; }

        public override string ToString() => $"Placa: {Placa}, Marca: {Marca}, Precio del Alquiler: {PrecioAlquiler}";

    }
}
