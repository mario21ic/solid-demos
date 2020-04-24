using System;
using OpenClosed.Modelos;

namespace OpenClosed
{
    public class ReclutamientoIngeniero : IReclutamientoServicio
    {
        public Empleado Contratar(IPostulante persona) {
            Empleado empleado = new Empleado();
            empleado.Nombre = persona.Nombre;
            empleado.Apellidos = persona.Apellidos;
            empleado.Email = $"{empleado.Nombre}.{empleado.Apellidos}.ing@mario21ic.com";
            
            return empleado;
        }
    }
}