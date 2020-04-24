using System;
using OpenClosed.Modelos;

namespace OpenClosed
{
    public interface IPostulante
    {
        string Nombre { get; set; }
        string Apellidos { get; set; }

        IReclutamientoServicio Procesador { get; set; }
    }
}