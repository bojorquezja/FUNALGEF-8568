using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    public class Carro
    {
        public double PrecioAlquiler { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public override string? ToString()
        {
            return $"Placa: {Placa}\nMarca: {Marca}\nPrecio de alquiler: {PrecioAlquiler}";
        }
    }
    public class Cliente
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public double PagoMaximo { get; set; }
        public override string? ToString()
        {
            return $"DNI: {Dni}\nNombre: {Nombre}\nPago maximo: {PagoMaximo}";
        }
    }
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
    public class AlquilerUtil
    {
        public double PrecioAlquiler { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public override string? ToString()
        {
            return $"Placa: {Placa}\nMarca: {Marca}\nPrecio de alquiler: {PrecioAlquiler}";
        }
    }
    }
//hola
//jola 2
//hola 3