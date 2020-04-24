using System;
using System.Collections.Generic;
using OpenClosed.Modelos;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPostulante> personas = new List<IPostulante>(){
              new Persona{ Nombre="Ivan", Apellidos="Cuadros"},
              new Ingeniero{ Nombre="Juan", Apellidos="Perez" },
              new Tecnico{ Nombre="Steve", Apellidos="Jobs" },
            };

            List<Empleado> empleados = new List<Empleado>();
            foreach (var persona in personas) {
                empleados.Add(persona.Procesador.Contratar(persona));
            }
            foreach (var empleado in empleados) {
                Console.WriteLine($"Bienvenido {empleado.Nombre} {empleado.Apellidos} - {empleado.Email}");
            }
            
            Console.ReadLine();
        }
    }
}
