using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    using AlquilerCarros;
    internal class alquiler
    {
        
        public int numero { get; set; }
        public carro  carroalq { get; set; }
        public Cliente contratante   { get; set; }
        public double precio { get; set; }
        
            public override string ToString()
        {
            return $"ALQUILER {numero}:" + $"\nCarro alquilado: {carroalq}"+$"\nCliente: {contratante}"+$"\nPrecio: {precio}";

        }
    }





    }

