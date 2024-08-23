using System.Threading.Channels;

namespace _20VecParalelosOrdenamiento;

class Program
{

    public class Problema1()
    {
        /*
         * Problema 1:
           
           Confeccionar un programa que permita cargar los nombres de 5 alumnos y sus notas respectivas. Luego ordenar las notas de mayor a menor. Imprimir las notas y los nombres de los alumnos.
         */
        private string[] alumnos = new string[5];
        private int[] notas = new int[5];
        
        public void Cargar()
        {
            
            Console.WriteLine("Ingrese 5 nombres de alumnos, seguido de sus notas: ");
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.Write("Nombre del alumno: ");
                string nombre = Console.ReadLine();
                alumnos[i] = nombre;
                
                Console.Write("Ingrese la nota de {0}: ", alumnos[i]);
                string nota = Console.ReadLine();
                int calificacion = int.Parse(nota);
                notas[i] = calificacion;
            }
        }

        public void Ordenar()
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                for (int j = 0; j < alumnos.Length - 1; j++)
                {
                    if (notas[j] < notas[j + 1])
                    {
                        int aux;
                        aux = notas[j];
                        notas[j] = notas[j + 1];
                        notas[j + 1] = aux;

                        string auxName;
                        auxName = alumnos[j];
                        alumnos[j] = alumnos[j + 1];
                        alumnos[j + 1] = auxName;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Lista alumnos ordenada por calificacion: ");
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine("- {0} - {1}",notas[i], alumnos[i]);
            }
        }
    }

    public class ProblemaPropuesto()
    {

        /*
         * Cargar en un vector los nombres de 5 paises y en otro vector paralelo la cantidad de habitantes del mismo. Ordenar alfabéticamente e imprimir los resultados. Por último ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir nuevamente.
         */
        private string[] paises = new string[5];
        private int[] habitantes = new int[5];

        public void Cargar()
        {
            Console.WriteLine("Ingrese los nombres de los paises: ");
            for (int i = 0; i < paises.Length; i++)
            {
                Console.Write("Ingrese el nombre del pais: ");
                string nombre = Console.ReadLine();
                paises[i] = nombre;
                
                Console.Write("Cantidad de habitantes: ");
                string cantidad = Console.ReadLine();
                int cant = int.Parse(cantidad);
                habitantes[i] = cant;
            }
        }

        public void Ordenar()
        {
            for (int i = 0; i < paises.Length; i++)
            {
                for (int j = 0; j < paises.Length - 1; j++)
                {
                    if (paises[j].CompareTo(paises[j + 1]) > 0)
                    {
                        string aux;
                        aux = paises[j];
                        paises[j] = paises[j + 1];
                        paises[j + 1] = aux;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Lista de Paises ordenados alfabeticamente:");
            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine("- {0}, habitantes: {1}", paises[i], habitantes[i]);
            }
        }

    }
    static void Main(string[] args)
    {
        // Problema1 pro1 = new Problema1();
        // pro1.Cargar();
        // pro1.Ordenar();
        // pro1.Imprimir();

        ProblemaPropuesto pro2 = new ProblemaPropuesto();
        pro2.Cargar();
        pro2.Ordenar();
        pro2.Imprimir();
    }
}