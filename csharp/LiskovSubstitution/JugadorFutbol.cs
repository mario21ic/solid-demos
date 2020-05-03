using System;

namespace LiskovSubstitution
{
    public class JugadorFutbol : Jugador, IEquipoJugador
    {
        private Equipo Equipo;
        public void AsignarEquipo(Equipo equipo)
        {
            Equipo = equipo;
        }

        public string ObtenerEquipo()
        {
            return Equipo.Nombre;
        }

        public string ObtenerValor(Categoria categoria) {
            string valorMercado = "";
            switch (categoria)
            {
                case Categoria.Profesional:
                    valorMercado = "5000";
                    break;
                case Categoria.Amateur:
                    valorMercado = "1000";
                    break;
            }
            return valorMercado;
        }
    }
}
