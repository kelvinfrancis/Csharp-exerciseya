﻿using System;
using System.Threading;

namespace Herencia
{
    internal class PublicacionVideo : Publicacion
    {
        // Variables
        protected bool seReproduce = false;
        protected int duracionActual = 0;

        private Timer reloj;
        
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

        public void Play()
        {
            if (!seReproduce)
            {
                seReproduce = true;
                Console.WriteLine("Reproduciendo...");
                reloj = new Timer(Reproduccion,
                    null, 0, 1000);
            }

        }

        public void Stop()
        {
            if (seReproduce)
            {
                seReproduce = false;
                Console.WriteLine("\nDetenido en {0}s",duracionActual);
                duracionActual = 0;
                reloj.Dispose();
            }
        }

        private void Reproduccion(Object o)
        {
            if (duracionActual < DuracionVideo)
            {
                duracionActual++;
                Console.WriteLine("Video en {0}s", duracionActual);
                GC.Collect(); // garbage collector
            }
            else
            {
                Stop();
            }
        }

    }
}

