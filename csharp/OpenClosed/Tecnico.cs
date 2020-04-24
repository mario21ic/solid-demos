using System;
using OpenClosed.Modelos;

namespace OpenClosed
{
    public class Tecnico : IPostulante
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public  IReclutamientoServicio Procesador { get; set; } = new ReclutamientoTecnico();
    }
}