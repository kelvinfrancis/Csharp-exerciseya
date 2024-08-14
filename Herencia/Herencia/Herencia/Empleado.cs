namespace Herencia;

public class Empleado
{
    // Propiedades
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public double Salario { get; set; }
    
    // Constructores
    public Empleado() { }

    public Empleado(string nombre, string apellido, double salario)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Salario = salario;
    }
    // Metodos
    public void Trabajar()
    {
        Console.WriteLine("Estoy trabajando");
    }

    public void Descansar()
    {
        Console.WriteLine("Estoy descansando");
    }
    
}