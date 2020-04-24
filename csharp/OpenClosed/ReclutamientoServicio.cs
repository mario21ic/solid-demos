using System;
using OpenClosed.Modelos;

namespace OpenClosed
{
    public class ReclutamientoServicio : IReclutamientoServicio
    {
        public Empleado Contratar(IPostulante persona) {
            Empleado empleado = new Empleado();
            empleado.Nombre = persona.Nombre;
            empleado.Apellidos = persona.Apellidos;
            empleado.Email = $"{empleado.Nombre}.{empleado.Apellidos}@mario21ic.com";
            
            return empleado;
        }
    }
}