using System;

namespace _17_VectoresParalelos
{
    internal class Program
    {
        class Problema1()
        {
            /*
            Problema:
            Desarrollar un programa que permita cargar 5 nombres de personas y sus edades respectivas. Luego de realizar la carga por teclado de todos los datos imprimir los nombres de las personas mayores de edad (mayores o iguales a 18 años)
            */

            string[] nombres;
            int[] edades;

            // Cargar datos
            public void Cargar()
            {
                Console.Write("Ingrese la cantidad de personas: ");
                string cantidad = Console.ReadLine();
                int cant = int.Parse(cantidad);
                nombres = new string[cant];
                edades = new int[cant];

                for (int i = 0; i < nombres.Length; i++)
                {
                    Console.Write("Ingrese un nombre: ");
                    string linea = Console.ReadLine();
                    nombres[i] = linea;

                    Console.Write("Ingrese la edad: ");
                    string edad = Console.ReadLine();
                    edades[i] = int.Parse(edad);
                }
            }
           
            public void ImprimirMayores()
            {
                Console.WriteLine("Las personas mayores de edad son: ");
                for (int i = 0;i < nombres.Length;i++)
                {
                    if (edades[i] >= 18)
                        Console.WriteLine(nombres[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Problema1 pb1 = new Problema1();
            pb1.Cargar();
            pb1.ImprimirMayores();
        }
    }
}
