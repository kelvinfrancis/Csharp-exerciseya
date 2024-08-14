namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publicacion post1 = new Publicacion("Gracias por los saludos de cumpleaños",true,"BookerT");
            Console.WriteLine(post1.ToString());

            PublicacionImagen imagen1 = new PublicacionImagen("Mi nuevo perro", "BookerTK", "https://imagen.com/perrito", true);
            Console.WriteLine(imagen1.ToString());

            PublicacionVideo video1 = new PublicacionVideo("Mi primer video","El pepe", true, "https://video.com/primerVideo", 10);
            Console.WriteLine(video1.ToString());
            video1.Play();
            Console.WriteLine("Presione cualquier tecla para detener");
            Console.ReadKey();
            //video1.Stop();
            
            // Desafio
            Empleado empleado1 = new Empleado("Juan", "Perez", 23000);

            Jefe jefe1 = new Jefe("Booker", "TK", 50000, "Audi");

            Pasante pasante1 = new Pasante("Julian", "Polanco", 20, 30);
            
            jefe1.Dirigir();
            pasante1.Trabajar();

            Console.Read();
        }
    }
}
