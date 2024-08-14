
using System.Security.Cryptography.X509Certificates;

class Program
{
    /* Practica 1:
     * Se desea almacenar los sueldos de operarios. Cuando se ejecuta el programa se debe pedir la cantidad de sueldos a ingresar. Luego crear un vector con dicho tamaño.
     */

    class Problema_1()
    {
        int[] sueldos;

        public void Cargar()
        {
            Console.WriteLine("Cuantos sueldo cargara?");
            string linea;
            linea = Console.ReadLine();
            int cantidad = int.Parse(linea);
            sueldos = new int[cantidad];

            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.WriteLine("Ingrese sueldo:");
                linea = Console.ReadLine();
                sueldos[i] = int.Parse(linea);
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Lista de sueldos");
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.WriteLine(sueldos[i]);
            }
        }
    }

    class ProblemaPropuesto()
    {
        /*
         * Desarrollar un programa que permita ingresar un vector de n elementos, ingresar n por teclado. Luego imprimir la suma de todos sus elementos
         */

        public int[] elementos;

        public void CargarElementos()
        {
            Console.WriteLine("Ingrese la cantidad de elementos: ");
            string cantidad = Console.ReadLine();
            int cant = int.Parse(cantidad);
            elementos = new int[cant];
            
            for (int i = 0; i < elementos.Length; i++)
            {
                Console.WriteLine("Ingrese los valores");
                string elemento;
                elemento = Console.ReadLine();
                elementos[i] = int.Parse(elemento);
            }
        }

        public void ImprimirSuma()
        {
            Console.WriteLine("La suma total de los elementos del vector es: {0}", elementos.Sum());
        }
        
    }
    private static void Main(string[] args)
    {
        //Problema_1 pv_1 = new Problema_1();
        //pv_1.Cargar();
        //pv_1.Imprimir();
        
        ProblemaPropuesto pp_1 = new ProblemaPropuesto();
        pp_1.CargarElementos();
        pp_1.ImprimirSuma();
        
    }

}