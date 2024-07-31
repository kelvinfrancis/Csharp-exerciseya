using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class PublicacionImagen : Publicacion
    {
        // Propiedad nueva
        public string UrlImagen { get; set; }

        // Constructor por defecto
        public PublicacionImagen() { }

        // Constructor parametrizado
        public PublicacionImagen(string titulo, string autor, string urlImagen, bool esPublico)
        {
            this.ID = CrearID();
            this.Titulo = titulo;
            this.Autor = autor;
            this.UrlImagen = urlImagen;
            this.EsPublico = esPublico;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - Creado por: {3}", this.ID, this.Titulo, this.UrlImagen, this.Autor);
        }

    }
}
