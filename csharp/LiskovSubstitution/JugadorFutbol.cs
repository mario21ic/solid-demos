using System;

namespace LiskovSubstitution
{
    public class JugadorFutbol : Jugador
    {
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
