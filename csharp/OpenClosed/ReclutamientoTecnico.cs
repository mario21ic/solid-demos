using System;
using OpenClosed.Modelos;

namespace OpenClosed
{
    public class ReclutamientoTecnico : IReclutamientoServicio
    {
        public Empleado Contratar(IPostulante persona) {
            Empleado empleado = new Empleado();
            empleado.Nombre = persona.Nombre;
            empleado.Apellidos = persona.Apellidos;
            empleado.Email = $"{empleado.Nombre}.{empleado.Apellidos}.tec@mario21ic.com";
            
            return empleado;
        }
    }
}