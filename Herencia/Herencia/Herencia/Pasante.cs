using System.Security.AccessControl;
using System.Threading.Channels;
namespace Herencia;

public class Pasante : Empleado
{
    public int HorasDeTrabajo { get; set; }
    public int HorasDeEscuela { get; set; }
    
    // constructores
    public Pasante() { }

    public Pasante(string nombre, string apellido, int horasDeTrabajo, int horasDeEscuela)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.HorasDeTrabajo = horasDeTrabajo;
        this.HorasDeEscuela = horasDeEscuela;
    }

    public void Aprender()
    {
        Console.WriteLine("Estoy aprendiendo durante {0} cantidad de horas", HorasDeTrabajo);
    }
    
    public void Trabajar()
    {
        Console.WriteLine("Estoy trabanjando {0} horas a la semana", HorasDeTrabajo);
    }
}