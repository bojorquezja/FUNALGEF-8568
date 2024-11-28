using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    internal class Cliente
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public double PagoMaximo { get; set; }

        public Cliente(int dni, string nombre, double pagomaximo)
        {
            Dni = dni;
            Nombre = nombre;
            PagoMaximo = pagomaximo;
        }
        public override string ToString()
        {
            return $"Dni: {Dni} \nNombre: {Nombre} \nPago Maximo:s/{PagoMaximo}";
        }
    }
}
