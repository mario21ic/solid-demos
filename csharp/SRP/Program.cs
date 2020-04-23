using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new PagoService().Registrar(1, 0, 30));
            Console.WriteLine(new PagoService().Registrar(0, 500, 30));
            Console.WriteLine(new PagoService().Registrar(2, 500, 30));

            Console.WriteLine("Hello World!");
        }
    }
}
