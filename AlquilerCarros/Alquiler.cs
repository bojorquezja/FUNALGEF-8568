using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlquilerCarros
{
    internal class Alquiler
    {
        public int Numero { get; set; }
        public string Carro { get; set; }
        public string Cliente { get; set; }
        public double Precio { get; set; }

        public override string ToString()
        {
            return "Numero:" + Numero + "Carro: " + Carro + "Cliente: " + Cliente + "Precio: " + Precio;
        }

    }
}
