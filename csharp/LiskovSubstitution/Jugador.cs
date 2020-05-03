using System;

namespace LiskovSubstitution
{
    public class Jugador //: IJugador
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        private Equipo Equipo { get; set; }
        public Categoria Categoria { get; set; }

        public string GetEquipo() => Equipo.Nombre;

        public virtual void AsignarEquipo(Equipo equipo) {
            Equipo = equipo;
        }

        public virtual void AsignarCategoria(Categoria categoria)
        {
            Categoria = categoria;
        }
    }
}
