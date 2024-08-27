using System.Threading.Channels;

namespace _21EstructuraDatosTipoMatriz;

class Program
{
    class Problema1()
    {
        /*
         * Crear una matriz de 3 filas por 5 columnas con elementos de tipo int, cargar sus componentes y luego imprimirlas.
         */
        private int[,] matriz;

        public void Cargar()
        {
            matriz = new int[3, 5];
            for (int f = 0; f < 3; f++) // Filas
            {
                for (int c = 0; c < 5; c++) // Columnas
                {
                    Console.WriteLine("Ingrese los elementos: ");
                    string linea;
                    linea = Console.ReadLine();
                    matriz[f, c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(matriz[f,c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

    class Problema2()
    {
        /*
         * Crear y cargar una matriz de 4 filas por 4 columnas. Imprimir la diagonal principal.
           x    -    -    -
           -    x    -    -
           -    -    x    -
           -    -    -    x
         */
        private int[,] matriz = new int[4, 4];

        public void Cargar()
        {
            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.WriteLine("Ingrese los valores para {0}, {1}:", f,c);
                    string linea = Console.ReadLine();
                    matriz[f, c] = int.Parse(linea);
                }
            }
        }

        public void ImprimirDiagonal()
        {
            for (int k = 0; k < 4; k++)
            {
                Console.Write(matriz[k,k] + " ");
            }
            Console.ReadKey();
        }
    }

    class Problema3()
    {
        /*
         * Crear y cargar una matriz de 3 filas por 4 columnas. Imprimir la primer fila. Imprimir la última fila e imprimir la primer columna.
           
         */
        private int[,] matriz = new int[3,4];

        public void Cargar()
        {
            Console.WriteLine("Ingrese los valores de la matriz 3 x 4: ");
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write("Ingrese el valor de {0},{1}: ",f,c);
                    string linea = Console.ReadLine();
                    matriz[f, c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir()
        {
            // primera fila
            Console.WriteLine("Primera fila: ");
            for (int c = 0; c < 4; c++)
            {
                Console.Write(matriz[0,c] + " ");
            }
            Console.WriteLine();
            
            // ultima fila
            Console.WriteLine("Ultima fila: ");
            for (int c = 0; c < 4; c++)
            {
                Console.Write(matriz[2,c] + " ");
            }
            Console.WriteLine();
            
            // primera columna
            Console.WriteLine("Primera columna: ");
            for (int f = 0; f < 3; f++)
            {
                Console.WriteLine(matriz[f,0]);
            }
        }
    }

    class ProblemaProp()
    {
        /*
         * Crear una matriz de 2 filas y 5 columnas. Realizar la carga de componentes por columna (es decir primero ingresar toda la primer columna, luego la segunda columna y así sucesivamente)
           Imprimir luego la matriz.
         */

        private int[,] matriz = new int[2, 5];

        public void Cargar()
        {
            for (int c = 0; c < 5; c++)
            {
                for (int f = 0; f < 2; f++)
                {
                    Console.Write("Ingrese los valores por columnas {0} x {1}: ",f,c);
                    string linea = Console.ReadLine();
                    matriz[f,c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Matriz ingresada: ");
            for (int f = 0; f < 2; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(matriz[f,c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    static void Main(string[] args)
    {
        // Problema1 pro1 = new Problema1();
        // pro1.Cargar();
        // pro1.Imprimir();

        // Problema2 proDos = new Problema2();
        // proDos.Cargar();
        // proDos.ImprimirDiagonal();

        // Problema3 proTres = new Problema3();
        // proTres.Cargar();
        // proTres.Imprimir();

        ProblemaProp propuesto = new ProblemaProp();
        
        propuesto.Cargar();
        propuesto.Imprimir();
    }
}