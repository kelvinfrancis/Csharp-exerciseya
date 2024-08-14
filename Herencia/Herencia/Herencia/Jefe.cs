namespace Herencia;

public class Jefe : Empleado
{
    public string AutoDeEmpresa { get; set; }
    
    // Constructores
    public Jefe() { }

    public Jefe(string nombre, string apellido, double salario, string autoDeEmpresa)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Salario = salario;
        this.AutoDeEmpresa = autoDeEmpresa;
    }

    public void Dirigir()
    {
        Console.WriteLine("Soy el jefe");
    }
}