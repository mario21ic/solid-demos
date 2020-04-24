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
              new Persona{ Nombre="Ivan", Apellidos="Cuadros"},
              new Persona{ Nombre="Juan", Apellidos="Perez", EsIngeniero = true},
              new Persona{ Nombre="Steve", Apellidos="Jobs"},
            };

            List<Empleado> empleados = new List<Empleado>();
            foreach (var persona in personas) {
                empleados.Add(new ReclutamientoServicio().Contratar(persona));
            }
            foreach (var empleado in empleados) {
                Console.WriteLine($"Bienvenido {empleado.Nombre} {empleado.Apellidos}, {empleado.Email} EsIngeniero {empleado.EsIngeniero}");
            }
            
            Console.ReadLine();
            // Console.WriteLine("Hello World!");
        }
    }
}
