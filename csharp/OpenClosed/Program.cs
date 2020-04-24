using System;
using System.Collections.Generic;
using OpenClosed.Modelos;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>(){
              new Persona{ Nombre="Ivan", Apellidos="Cuadros", Rol = Rol.Tecnico},
              new Persona{ Nombre="Juan", Apellidos="Perez", Rol = Rol.Ingeniero},
              new Persona{ Nombre="Steve", Apellidos="Jobs", Rol = Rol.Tecnico},
            };

            List<Empleado> empleados = new List<Empleado>();
            foreach (var persona in personas) {
                empleados.Add(new ReclutamientoServicio().Contratar(persona));
            }
            foreach (var empleado in empleados) {
                Console.WriteLine($"Bienvenido {empleado.Nombre} {empleado.Apellidos} - {empleado.Email}");
                Console.WriteLine($"EsIngeniero {(empleado.Rol == Rol.Ingeniero ? "Si" : "No")}");
                Console.WriteLine($"EsTecnico {(empleado.Rol == Rol.Tecnico ? "Si" : "No")}");
            }
            
            Console.ReadLine();
        }
    }
}
