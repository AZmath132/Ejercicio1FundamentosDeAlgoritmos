using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Productos
    {
        string[] nombre = new string[0];
        double[] precio = new double[0];
        int posicion = 0;
        public int buscar(string nom)
        {
            int indice = Array.IndexOf(nombre, nom);
            return indice;
        }
        public void insertar()
        {
            Console.Write("Ingrese nombre: ");
            string nom = Console.ReadLine().Trim();
            if(buscar(nom)==-1)
            {
                Array.Resize(ref nombre, nombre.Length + 1);
                Array.Resize(ref precio, precio.Length + 1);
                nombre[posicion] = nom;
                Console.Write("Ingrese precio: ");
                double pre= double.Parse(Console.ReadLine());
                precio[posicion] = pre;
                posicion++;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("\nEl producto agregado correctamente");
                Console.ResetColor();
            }
        }
        public void mostrar()
        {
            Console.SetCursorPosition(0, 14);
            Console.Write("POSICIÓN");
            Console.SetCursorPosition(10, 14);
            Console.Write("NOMBRE");
            Console.SetCursorPosition(30, 14);
            Console.Write("PRECIO");
            for(int i=0; i<nombre.Length; i++)
            {
                Console.SetCursorPosition(0, 15+i);
                Console.Write(i);
                Console.SetCursorPosition(10, 15 + i);
                Console.Write(nombre[i]);
                Console.SetCursorPosition(30, 15 + i);
                Console.Write(precio[i]);
            }
        }
        public void eliminar()
        {
            Console.Write("\nIngrese nombre a eliminar: ");
            string nom = Console.ReadLine().Trim();
            if(buscar(nom)!= -1)
            {
                for(int i=buscar(nom); i<nombre.Length-1;i++)
                {
                    nombre[i] =nombre[i+1];
                    precio[i] = precio[i + 1];
                }
                Array.Resize(ref nombre, nombre.Length - 1);
                Array.Resize(ref precio, precio.Length - 1);
                posicion--;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("\nEl producto eliminado correctamente");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEl producto no se puede eliminar porque no existe");
                Console.ResetColor();
            }
        }
        public void ordenar()
        {
            for(int i=0; i<nombre.Length-1; i++)
            {
                for(int j=0; j<nombre.Length -1 -i;j++)
                {
                    if(string.Compare(nombre[j],nombre[j+1])>0)
                    {
                        string temp=nombre[j];
                        double temp2=precio[j];
                        nombre[j] = nombre[j + 1];
                        precio[j] = precio[j + 1];
                        nombre[j + 1] = temp;
                        precio[j + 1] = temp2;
                    }
                }
            }
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("\nProductos ordenados correctamente");
            Console.ResetColor();
        }
        public void modificar()
        {
            Console.Write("\nIngrese nombre a modificar: ");
            string nom = Console.ReadLine().Trim();
            if(buscar(nom)!= -1)
            {
                int indice = buscar(nom);
                Console.Write("\nIngrese el nuevo nombre: ");
                string nuevoNom=Console.ReadLine().Trim();
                Console.Write("Ingrese nuevo precio: ");
                double nuevoPore = double.Parse(Console.ReadLine());
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEl producto no se puede modificar porque no existe");
                Console.ResetColor();
            }
        }
    }
  
}
