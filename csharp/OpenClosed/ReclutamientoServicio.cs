using System;
using OpenClosed.Modelos;

namespace OpenClosed
{
    public class ReclutamientoServicio
    {
        public Empleado Contratar(Persona persona) {
            Empleado empleado = new Empleado();
            empleado.Nombre = persona.Nombre;
            empleado.Apellidos = persona.Apellidos;
            empleado.Email = $"{empleado.Nombre}.{empleado.Apellidos}@mario21ic.com";
            empleado.EsIngeniero = persona.EsIngeniero;

            return empleado;
        }
    }
}