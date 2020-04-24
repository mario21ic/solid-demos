using System;
using OpenClosed.Modelos;

namespace OpenClosed
{
    public class Ingeniero : IPostulante
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public  IReclutamientoServicio Procesador { get; set; } = new ReclutamientoIngeniero();
    }
}