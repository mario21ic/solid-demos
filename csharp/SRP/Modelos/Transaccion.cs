using System;

namespace csharp.Modelos
{
    public class Transaccion
    {
        public int idServicio { get; set; }
        public decimal Monto { get; set; }
        public Cliente Cliente { get; set; }
    }
}
