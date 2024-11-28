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

            Console.Write("Ingresa el precio del carro : ");

            RespuestaEs = double.Parse(Console.ReadLine());

            Array.Resize(ref lista3, lista3.Length + 1);

            lista3[posicion3] = RespuestaEs;

            posicion3 = posicion3 + 1;

        }

        public void mostrar()

        {

            if (lista1.Length == 0)

            {

                Console.WriteLine("No hay carros registrados.");

                return;

            }



            for (int i = 0; i < lista1.Length; i++)

            {

                Console.WriteLine($"Datos del auto N°{i + 1}");

                Console.WriteLine($"Placa del vehiculo: {lista1[i]}");

                Console.WriteLine($"La marca del vehiculo es: {lista2[i]}");

                Console.WriteLine($"El precio del carro: {lista3[i]}");

            }

        }

        public void eliminar()

        {

            if (lista1.Length == 0)

            {

                Console.WriteLine("No hay animales para eliminar.");

                return;

            }



            Console.WriteLine("Selecciona el número del carro que deseas eliminar:");

            for (int i = 0; i < lista1.Length; i++)

            {

                Console.WriteLine($"{i + 1}. {lista1[i]}");

            }



            int carroAEliminar;

            Console.Write("Ingresa el número del carro: ");

            bool validInput = int.TryParse(Console.ReadLine(), out carroAEliminar);





        }





    }

}
