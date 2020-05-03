using System;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado(
                new Email() {
                    Subject = "mario21@gmail.com"
                },
                new SMS() {
                    Numero = "966296635"
                }
            );
            empleado.Send();
        }
    }
}
