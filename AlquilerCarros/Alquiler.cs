using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    internal class Alquiler
    {
        public int Numero { get; set; }
        public Carro CarroAlq { get; set; }
        public Cliente Contratante { get; set; }
        public double Precio { get; set; }

        public Alquiler(int numero, Carro CarroAlq, Cliente contratante, double precio)
        {
            Numero = numero;
            Carro = CarroAlq;
            Contratante = contratante;
            Precio = precio;
        }

        public override string ToString()
        {
            return $"Número: {Numero} \nCarro: {CarroAlq}, \nCliente: {Contratante} \nPrecio: {Precio}";
        }
    }
}
