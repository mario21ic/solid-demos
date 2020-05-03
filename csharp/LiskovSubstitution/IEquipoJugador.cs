using System;

namespace LiskovSubstitution
{
    public interface IEquipoJugador
    {
        void AsignarEquipo(Equipo equipo);
        string ObtenerEquipo();
    }
}