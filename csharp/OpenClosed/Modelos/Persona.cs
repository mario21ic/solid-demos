using System;

namespace OpenClosed.Modelos
{
    public class Persona : IPostulante
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public  IReclutamientoServicio Procesador { get; set; } = new ReclutamientoServicio();
    }
}