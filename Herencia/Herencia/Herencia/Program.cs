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

            Console.Read();
        }
    }
}
