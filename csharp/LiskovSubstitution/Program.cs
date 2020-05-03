using System;

namespace LiskovSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jugador jugador = new Jugador();
            // Jugador jugador = new JugadorFutbol();
            IEquipoJugador jugador = new JugadorFutbol();
            // Jugador jugador = new JugadorTenis();
            jugador.Nombres = "Juan";
            jugador.Apellidos = "Perez Perez";

            jugador.AsignarCategoria(Categoria.Profesional);
            jugador.AsignarEquipo(new Equipo() { Nombre = "Barcelona FC"});

            // Console.WriteLine($"{jugador.Nombres} {jugador.Apellidos} esta en el equipo {jugador.GetEquipo()}");
            Console.WriteLine($"{jugador.Nombres} {jugador.Apellidos}");

            Console.ReadLine();
        }
    }
}
