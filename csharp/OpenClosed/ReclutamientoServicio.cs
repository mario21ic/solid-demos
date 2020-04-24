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

            switch(persona.Rol) {
                case Rol.Ingeniero:
                    empleado.Email = $"{empleado.Nombre}.{empleado.Apellidos}.ing@mario21ic.com";
                    break;
                case Rol.Tecnico:
                    empleado.Email = $"{empleado.Nombre}.{empleado.Apellidos}.tec@mario21ic.com";
                    break;
            }

            empleado.Rol = persona.Rol;

            return empleado;
        }
    }
}