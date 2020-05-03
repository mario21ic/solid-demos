using System;

namespace LiskovSubstitution
{
    public interface IJugador
    {
        string Nombres { get; set; }
        string Apellidos { get; set; }
        Categoria Categoria { get; set; }
        void AsignarCategoria(Categoria categoria);
    }
}