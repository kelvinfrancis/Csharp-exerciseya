namespace _22MatricesCantFilasColumnas;

class Program
{
    class Problema1()
    {
        /*
         * Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir la matriz completa y la última fila.
         */
        private int[,] matriz;

        public void Cargar()
        {
            Console.Write("Ingrese la cantidad de filas: ");
            string linea = Console.ReadLine();
            int filas = int.Parse(linea);
            
            Console.Write("Ingrese la cantidad de columnas: ");
            string linea2 = Console.ReadLine();
            int columnas = int.Parse(linea2);
            
            // Crear dimension de la matriz
            matriz = new int[filas, columnas];
            
            // Cargar datos a matriz
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write("Ingrese el valor de {0}x{1}: ",f,c);
                    string valor = Console.ReadLine();
                    int valorNum = int.Parse(valor);
                    matriz[f, c] = valorNum;
                }
            }
        }

        public void Imprimir()
        {
            // Matriz completa
            Console.WriteLine("Matriz Completa:");
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write(matriz[f,c] + " ");
                }
                Console.WriteLine();
            }
            
            // Ultima fila
            int ultimaF = matriz.GetLength(0) - 1;
            Console.WriteLine("Ultima fila: ");
            for (int c = 0; c < matriz.GetLength(1); c++)
            {
                Console.Write(matriz[ultimaF, c] + " ");
            }
        }
    }
    class Problema2()
    {
        /*
         * Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir el mayor elemento y la fila y columna donde se almacena.
         */
        private int[,] matriz;
        public void Cargar()
        {
            Console.Write("Ingrese la cantidad de filas: ");
            string linea = Console.ReadLine();
            int filas = int.Parse(linea);
            
            Console.Write("Ingrese la cantidad de columnas: ");
            string linea2 = Console.ReadLine();
            int columnas = int.Parse(linea2);
            
            // Crear dimension de la matriz
            matriz = new int[filas, columnas];
            
            // Cargar datos a matriz
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write("Ingrese el valor de {0}x{1}: ",f,c);
                    string valor = Console.ReadLine();
                    int valorNum = int.Parse(valor);
                    matriz[f, c] = valorNum;
                }
            }
        }

        public void ImprimirMayor()
        {
            int mayor = matriz[0, 0];
            int filaM = 0;
            int columnaM = 0;
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    if (matriz[f,c] > mayor)
                    {
                        mayor = matriz[f, c];
                        filaM = f;
                        columnaM = c;
                    }
                }
            }
            Console.WriteLine("El mayor numero es: {0}, y se encuentra en la fila: {1}, columna: {2}.", mayor, filaM,
                columnaM);
        }
    }

    class Problema3()
    {
        /* Crear y cargar una matriz de 3 filas por 4 columnas. Imprimir la primer fila. Imprimir la última fila e imprimir la primer columna. */
        private int[,] matriz = new int[3,4];
        public void Cargar()
        {
            // Cargar datos a matriz
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write("Ingrese el valor de {0}x{1}: ",f,c);
                    string valor = Console.ReadLine();
                    int valorNum = int.Parse(valor);
                    matriz[f, c] = valorNum;
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
            
            // Primera columna
            Console.WriteLine("Primera columna: ");
            for (int f = 0; f < 3; f++)
            {
                Console.WriteLine(matriz[f,0]);
            }
        }

    }

    class ProblemaPropuesto()
    {
        /* Crear una matriz de 2 filas y 5 columnas. Realizar la carga de componentes por columna (es decir primero ingresar toda la primer columna, luego la segunda columna y así sucesivamente) Imprimir luego la matriz.*/
        private int[,] matriz = new int[2,5];
        public void Cargar()
        {
            // Cargar datos a matriz
            for (int c = 0; c < matriz.GetLength(1); c++)
            {
                for (int f = 0; f < matriz.GetLength(0); f++)
                {
                    Console.Write("Ingrese el valor de {0}x{1}: ",f,c);
                    string valor = Console.ReadLine();
                    int valorNum = int.Parse(valor);
                    matriz[f, c] = valorNum;
                }
            }
        }
        
        public void Imprimir()
        {
            // Matriz
            Console.WriteLine("Matriz: ");
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write(matriz[f,c] + " ");
                }
                Console.WriteLine();
            }

        }
    }
    static void Main(string[] args)
    {
        // Problema1 proUno = new Problema1();
        // proUno.Cargar();
        // proUno.Imprimir();

        // Problema2 proDos = new Problema2();
        // proDos.Cargar();
        // proDos.ImprimirMayor();

        // Problema3 proTres = new Problema3();
        // proTres.Cargar();
        // proTres.Imprimir();

        // ProblemaPropuesto propuesto = new ProblemaPropuesto();
        // propuesto.Cargar();
        // propuesto.Imprimir();
    }
}