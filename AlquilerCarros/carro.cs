using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroUtil
{
    public class Carro
    {
        string[] lista1 = new string[0];
        string[] lista2 = new string[0];
        double[] lista3 = new double[0];

        int posicion = 0;
        int posicion2 = 0;
        int posicion3 = 0;

        public void crear()
        {
            string RespuestaN;
            Console.Write("Ingresa la placa del carro : ");
            RespuestaN = Console.ReadLine();
            Array.Resize(ref lista1, lista1.Length + 1);
            lista1[posicion] = RespuestaN;
            posicion = posicion + 1;
            Console.WriteLine("A agregado la placa del vehiculo");
            string RespuestaEd;
            Console.Write("Ingresa Marca : ");
            RespuestaEd = Console.ReadLine();
            Array.Resize(ref lista2, lista2.Length + 1);
            lista2[posicion2] = RespuestaEd;
            posicion2 = posicion2 + 1;
            Console.WriteLine("A agregado la marca del vehiculo ");
            double RespuestaEs;
            Console.Write("Ingresa la raza del animal : ");
            RespuestaEs = double.Parse(Console.ReadLine());
            Array.Resize(ref lista3, lista3.Length + 1);
            lista3[posicion3] = RespuestaEs;
            posicion3 = posicion3 + 1;
        }


    }
}
