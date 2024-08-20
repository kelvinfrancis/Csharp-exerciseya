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
    static void Main(string[] args)
    {
        Problema1 pro1 = new Problema1();
        pro1.Cargar();
        pro1.OrdenarMenorMayor();
    }
}