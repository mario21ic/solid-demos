using System;

namespace LiskovSubstitution
{
    public class JugadorTenis : Jugador
    {
        public override void AsignarEquipo(Equipo equipo) {
            throw new NotImplementedException("Soy un jugador de tenis y no necesito equipo");
        }
    }
}
