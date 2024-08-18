namespace _18_VectoresMayorYMenor
{
    internal class Program
    {
        /* Problema 1:
         Confeccionar un programa que permita cargar los nombres de 5 operarios y sus sueldos respectivos. Mostrar el sueldo mayor y el nombre del operario.
         */

        /* Problema 2:
         Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro del vector
         */
        class Problema1()
        {
            string[] empleados = new string[5];
            int[] sueldos = new int[5];

            public void Cargar()
            {
                Console.WriteLine("Ingrese los nombres de los empreados: ");
                for (int i = 0; i < empleados.Length; i++)
                {
                    Console.Write("Ingrese un nombre: ");
                    string nombre = Console.ReadLine();
                    empleados[i] = nombre;

                    Console.Write("Ingrese su sueldo: ");
                    string sueldo = Console.ReadLine();
                    sueldos[i] = int.Parse(sueldo);
                }
            }

            public void ImprimirSueldoMayor()
            {
                int mayor;
                mayor = sueldos[0];
                int indiceM = 0;
                for (int i = 1;i < sueldos.Length; i++)
                {
                    if (sueldos[i] > mayor)
                    {
                        mayor = sueldos[i];
                        indiceM = i;

                    }
                }
                Console.WriteLine("Persona con el mayor sueldo es: {0}, con un sueldo de {1}", empleados[indiceM], mayor);
                Console.ReadKey();
            }
        }

        class Problema2()
        {
            int[] elementos;
            private int valorMenor;

            public void Cargar()
            {
                /*Cargar elementos del listado*/
                Console.Write("Ingrese la cantidad de elementos del listado: ");
                string cantidad = Console.ReadLine();
                int cant = int.Parse(cantidad);
                elementos = new int[cant];

                for (int i = 0; i < elementos.Length; i++)
                {
                    Console.Write("Ingrese un elemento: ");
                    string elemento = Console.ReadLine();
                    elementos[i] = int.Parse(elemento);
                }
            }

            public void ImprimirValorMenor()
            {
                valorMenor = elementos[0];
                /* Imprime el valor menor del listado, y valida si esta repetido */
                for (int i = 1; i < elementos.Length - 1; i++)
                {
                    if (elementos[i] < valorMenor)
                        valorMenor = elementos[i];
                }
                
                Console.WriteLine("El menor valor es {0}", valorMenor);
            }

            public void RepiteMenor()
            {
                int repetido = 0;
                for (int i = 0; i < elementos.Length; i++)
                {
                    if (valorMenor == elementos[i])
                        repetido += 1;
                }

                if (repetido > 1)
                    Console.WriteLine("El valor esta repetido");
                else
                    Console.WriteLine("El valor NO esta repetido");
            }
        }
        static void Main(string[] args)
        {
            // Problema1 pb1 = new Problema1();
            // pb1.Cargar();
            // pb1.ImprimirSueldoMayor();

            Problema2 pro2 = new Problema2();
            pro2.Cargar();
            pro2.ImprimirValorMenor();
            pro2.RepiteMenor();
        }
    }
}
