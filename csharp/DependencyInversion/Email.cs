using System;

namespace DependencyInversion
{
    public class Email
    {
        public string Subject { get; set; }
        public string Content { get; set; }
        public void EnviarEmail() {
            Console.Write($"Enviar Email al nro {this.Subject}");
        }
    }
}