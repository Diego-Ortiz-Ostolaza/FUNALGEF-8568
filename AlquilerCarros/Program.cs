using CarroUtil;
byte opcion;
string regresar;
int ops;
do
{
    Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine("     ALQUILER DE CARROS \n");

    Console.WriteLine("******************* MENÚ ******************");

    Console.WriteLine("* 1. Crear, listar y eliminar carro       *");

    Console.WriteLine("* 2. Crear, listar y eliminar cliente     *");

    Console.WriteLine("* 3. Crear, listar y alquilar             *");

    Console.WriteLine("* 0. Salir                                *");

    Console.WriteLine("*******************************************\n");



    Console.Write("Ingrese opcion: ");


    Console.ForegroundColor = ConsoleColor.Red;
    while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 3)
    {

        Console.Write("Error: Ingrese opcion: ");

    }

    Console.ForegroundColor = ConsoleColor.DarkCyan;

    switch (opcion)
    {

        case 0: Environment.Exit(0); break;


        case 1:
            Carro d = new Carro();
            Console.WriteLine("     Opción carro util \n");

            Console.WriteLine("******************* MENÚ ******************");

            Console.WriteLine("* 1. Agregar información del del carro       *");

            Console.WriteLine("* 2. Mostrar la información del carro        *");

            Console.WriteLine("* 3. Eliminar la información del carro        *");

            Console.WriteLine("* 0. Salir                                *");

            Console.WriteLine("*******************************************\n");
            ops = int.Parse(Console.ReadLine());
            switch (ops)
            {

                case 0: Environment.Exit(0); break;

                case 1: d.crear(); break;

                case 2:
                    break;

                case 3: break;


            }

            break;

        case 2: break;

        case 3: break;




    }

    Console.WriteLine("Desea regresar al menú? [si]: ");

    regresar = Console.ReadLine();


    Console.Clear();
    Console.ResetColor();
} while (regresar == "si");









