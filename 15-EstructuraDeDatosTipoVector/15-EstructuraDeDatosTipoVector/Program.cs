using System.Collections.Immutable;
using System.Runtime.InteropServices;

namespace _15_EstructuraDeDatosTipoVector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio3();
            //Ejercicio4();
            Console.ReadKey();
        }

        public static void Ejercicio1()
        {
            /*
             Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
             El valor acumulado de todos los elementos del vector.
             El valor acumulado de los elementos del vector que sean mayores a 36.
             Cantidad de valores mayores a 50.
             */

            int[] vector = new int[8];
            Console.WriteLine("Ingrese 8 valores. ");
            Console.WriteLine("Ingrese un valor: ");
            for (int i = 0; i < vector.Length; i++)
                vector[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Los numeros del vector son: {0}", string.Join(",", vector));
            Console.WriteLine("La suma de todos los numeros es: {0}", vector.Sum());
            Console.WriteLine("Los valores mayores a 36 son: ");
            foreach (int numero in vector)
                if (numero > 36)
                    Console.WriteLine(numero);

            Console.WriteLine("Cantidad de valores mayores a 50.");
            int Mayor50 = 0;
            foreach (int num in vector)
                if (num > 50)
                    Mayor50 += 1;

            Console.WriteLine(Mayor50);
        }

        public static void Ejercicio2()
        {
            /*Realizar un programa que pida la carga de dos vectores numéricos enteros de 4 elementos. Obtener la suma de los dos vectores, dicho resultado guardarlo en un tercer vector del mismo tamaño. Sumar componente a componente.*/

            int[] vector_1 = new int[4];
            int[] vector_2 = new int[4];

            Console.WriteLine("Ingrese los 4 valores del primer vector");
            for (int i = 0; i < vector_1.Length; i++)
            {
                vector_1[i] = (int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Ingrese los 4 valores del segundo vector");
            for (int i = 0; i < vector_2.Length; i++)
            {
                vector_2[i] = (int.Parse(Console.ReadLine()));
            }

            int[] vector_3 = new int[4];
            for (int i = 0; i < vector_3.Length; i++)
            {
                vector_3[i] = vector_1[i] + vector_2[i];
            }
            Console.WriteLine("La suma de los dos vectores es {0}", string.Join(",", vector_3));
        }

        public static void Ejercicio3()
        {
            /*Se tienen las notas del primer parcial de los alumnos de dos cursos, el curso A y el curso B, cada curso cuenta con 5 alumnos.Realizar un programa que muestre el curso que obtuvo el mayor promedio general.*/

            int[] vector1 = new int[5];
            int[] vector2 = new int[5];

            Console.WriteLine("Ingrese las notas del primer curso:");
            for (int i = 0; i < vector1.Length; i++)
                vector1[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese las notas del segundo curso:");
            for (int i = 0; i < vector2.Length; i++)
                vector2[i] = int.Parse(Console.ReadLine());

            double promedioVector1 = (double)vector1.Sum() / (double)vector1.Length;
            double promedioVector2 = (double)vector2.Sum() / (double)vector2.Length;

            if (promedioVector1 > promedioVector2)
                Console.WriteLine("El primer curso tuvo un mayor promedio, con un promedio de: {0}", promedioVector1);
            else
                Console.WriteLine("El segundo curso tuvo un mayor promedio, con un promedio de: {0}", promedioVector2);
        }

        public static void Ejercicio4()
        {
            /*Cargar un vector de 10 elementos y verificar posteriormente si el mismo está ordenado de menor a mayor.*/
            int[] vector1 = new int[10];
            Console.WriteLine("Ingrese 10 numeros enteros: ");
            for (int i = 0; i < vector1.Length; i++)
                vector1[i] = int.Parse(Console.ReadLine());

            bool estaOrdenado = true;

            for (int i = 0; i < 9; i++)
                if (vector1[i+1] < vector1[i])
                {
                    estaOrdenado = false;
                }

            if (estaOrdenado)
                Console.WriteLine("El vector esta ordenado.");
            else
                Console.WriteLine("El vector no esta ordenado.");
        }
    }
}
