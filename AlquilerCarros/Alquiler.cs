﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    public class Alquiler
    {
        public int Numero {  get; set; }
        public Carro CarroAlq {  get; set; }
        public Cliente Contratante { get; set; }
        public double Precio { get; set; }
        public override string ToString()
        {
            return $"Número: {Numero}, Carro de alquiler: {CarroAlq}, Precio: {Precio}";
        }
    }
}
