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
    static void Main(string[] args)
    {
        // Problema1 pro1 = new Problema1();
        // pro1.Cargar();
        // pro1.OrdenarMenorMayor();

        Problema2 pro2 = new Problema2();
        pro2.CargarPaises();
        pro2.OrdenarPaises();
        pro2.Imprimir();
    }
}