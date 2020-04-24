using System;
using OpenClosed.Modelos;

namespace OpenClosed
{
    public interface IReclutamientoServicio
    {
         Empleado Contratar(IPostulante persona);
    }
}