using System;

namespace Herencia
{
    internal class PublicacionVideo : Publicacion
    {
        // Propiedades de Video
        public string UrlVideo { get; set; }
        public double DuracionVideo { get; set; }

        public PublicacionVideo() { }

        public PublicacionVideo(string titulo, string autor, bool esPublico, string urlVideo, double duracionVideo)
        {
            this.ID = CrearID();
            this.Titulo = titulo;
            this.Autor = autor;
            this.UrlVideo = urlVideo;
            this.EsPublico = esPublico;
            this.DuracionVideo = duracionVideo;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} min - Creado por: {4}", this.ID, this.Titulo, this.UrlVideo, this.DuracionVideo, this.Autor);
        }

    }
}

