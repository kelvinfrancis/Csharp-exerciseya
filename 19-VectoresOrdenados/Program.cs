using System.Threading.Channels;

namespace _19_VectoresOrdenados;

class Program
{
    // Prolema 1:
    // Se debe crear un vector donde almacede 5 sueldos, ornede de menor a mayor
    
    // Problema 2:
    // Definir un vector donde almacenar los nombres de 5 paises. Confeccionar el algoritmo de ordenamiento alfabético.
    
    //Problema propuesto:
    // Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector.
    public class Problema1()
    {
        private int[] sueldos = new int[5];

        public void Cargar()
        {
            Console.WriteLine("Ingrese 5 sueldos: ");

            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.Write("Ingrese un sueldo: ");
                string sueldo = Console.ReadLine();
                sueldos[i] = Int32.Parse(sueldo);
            }
        }

        public void OrdenarMenorMayor()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                {
                    if (sueldos[j] > sueldos[j+1])
                    {
                        int aux;
                        aux = sueldos[j];
                        sueldos[j] = sueldos[j + 1];
                        sueldos[j + 1] = aux;
                    }
                }
            }
            
            // imprimir lista ordenada
            Console.WriteLine("Lista ordenada: ");
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.WriteLine(sueldos[i]);
            }
        }
    }

    public class Problema2()
    {
        /*
         * Definir un vector donde almacenar los nombres de 5 paises. Confeccionar el algoritmo de ordenamiento alfabético.
         */
        string[] paises = new string[5];
        private string aux;
        public void CargarPaises()
        {
            Console.WriteLine("Ingrese 5 nombres de paises: ");
            for (int i = 0; i < paises.Length; i++)
            {
                Console.Write("Nombre del pais: ");
                string pais = Console.ReadLine();
                paises[i] = pais;
            }
        }

        public void OrdenarPaises()
        {
            for (int i = 0; i < paises.Length; i++)
            {
                for (int j = 0; j < paises.Length - 1; j++)
                {
                    if (paises[j].CompareTo(paises[j + 1]) > 0)
                    {
                        aux = paises[j];
                        paises[j] = paises[j + 1];
                        paises[j + 1] = aux;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Lista ordenada:");
            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine("- {0}",paises[i]);
            }
        }
    }

    public class ProblemaPropuesto()
    {
        private int[] elementos;
        //Problema propuesto: Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector.

        public void Cargar()
        {
            Console.WriteLine("Ingrese la cantidad de elementos del vector: ");
            string cantidad = Console.ReadLine();
            int cant = Int32.Parse(cantidad);
            elementos = new int[cant];

            for(int i=0; i < elementos.Length; i++)
            {
                Console.WriteLine("Ingrese los {0} valores: ", elementos.Length)
                Console.Write("Ingrese el valor: ");
                string linea = Console.ReadLine();
                int elemento = Int32.Parse(linea);
                elementos[i] = elemento;
            }
        }

        public void Ordenar()
        {
            for(int i = 0; i < elementos.Length; i++)
            {
                for(int j = 0 j < elementos.Length -1; j++)
                {
                    if(elementos[j] > elementos[j +  1])
                    {
                        int aux;
                        aux = elementos[j];
                        elementos[j] = elementos[j + 1]
                        elementos[j + 1] = aux;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Lista ordenada.")
            for(int i = 0; i < elementos.Length; i++)
            {
                Console.WriteLine(elementos[i]);
            }
        }
    }
    
    static void Main(string[] args)
    {
        // Problema1 pro1 = new Problema1();
        // pro1.Cargar();
        // pro1.OrdenarMenorMayor();

        // Problema2 pro2 = new Problema2();
        // pro2.CargarPaises();
        // pro2.OrdenarPaises();
        // pro2.Imprimir();

        ProblemaPropuesto pro3 = new ProblemaPropuesto();
        pro3.Cargar();
        pro3.Ordenar()
        pro3.Imprimir();
    }
}