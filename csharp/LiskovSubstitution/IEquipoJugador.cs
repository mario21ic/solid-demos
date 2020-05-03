using System;

namespace LiskovSubstitution
{
    public interface IEquipoJugador: IJugador
    {
        void AsignarEquipo(Equipo equipo);
        string ObtenerEquipo();
    }
}