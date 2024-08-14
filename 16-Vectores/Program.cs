
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

    private static void Main(string[] args)
    {
        Problema_1 pv_1 = new Problema_1();
        pv_1.Cargar();
        pv_1.Imprimir();


    }

}