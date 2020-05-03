using System;

namespace DependencyInversion
{
    public class SMS: IMensaje
    {
        public string Numero { get; set; }
        public string Mensaje { get; set; }
        public void EnviarMensaje() {
            Console.Write($"Enviar SMS al nro {this.Numero}\n");
        }
    }
}