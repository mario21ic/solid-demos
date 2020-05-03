using System;

namespace DependencyInversion
{
    public class Email: IMensaje
    {
        public string Subject { get; set; }
        public string Content { get; set; }
        public void EnviarMensaje() {
            Console.Write($"Enviar Email al nro {this.Subject}\n");
        }
    }
}