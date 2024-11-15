using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte opcion;
           string regresar;
            Productos p = new Productos();
            do
            {

                Console.WriteLine("BIENVENIDO AL SISTEMA DE REGISTRO DE PRODUCTOS\n");

                Console.WriteLine("******** MENÚ DE OPCIONES *******");

                Console.WriteLine("* 1 - Insertar         *");

                Console.WriteLine("* 2 - Mostrar          *");

                Console.WriteLine("* 3 - Eliminar         *");

                Console.WriteLine("* 4 - Ordenar          *");

                Console.WriteLine("* 5 - Modificar         *");

                Console.WriteLine("* 6 - Buscar          *");

                Console.WriteLine("* 0 - Salir           *");

                Console.WriteLine("*********************************\n");



                Console.Write("Ingrese una opción: ");



                while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 6)

                {

                    Console.Write("Error: Ingrese una opción: ");

                }



                switch (opcion)

                {

                    case 0: Environment.Exit(0); break;

                    case 1: p.insertar();  break;

                    case 2:p.mostrar(); break;

                    case 3: p.eliminar();  break;

                    case 4:p.ordenar(); break;

                    case 5:p.modificar(); break;

                    case 6: break;

                }



                Console.Write("\n\nPara regresar al menú [si] para salir cualquier otra tecla: ");

                regresar = Console.ReadLine();

                Console.Clear();

            } while (regresar == "si");

            Console.ReadKey();
        }
    }
}
