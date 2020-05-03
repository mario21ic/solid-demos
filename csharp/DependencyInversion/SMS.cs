using System;

namespace DependencyInversion
{
    public class SMS
    {
        public string Numero { get; set; }
        public string Mensaje { get; set; }
        public void EnviarSMS() {
            Console.Write($"Enviar SMS al nro {this.Numero}");
        }
    }
}