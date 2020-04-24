using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new PagoService().Registrar(new Modelos.Transaccion(){
                Cliente = new Modelos.Cliente(){
                    IdCliente = 1
                },
                Monto = 0,
                idServicio = 30
            }));

            Console.WriteLine(new PagoService().Registrar(new Modelos.Transaccion(){
                Cliente = new Modelos.Cliente(){
                    IdCliente = 0
                },
                Monto = 500,
                idServicio = 30
            }));

            Console.WriteLine(new PagoService().Registrar(new Modelos.Transaccion(){
                Cliente = new Modelos.Cliente(){
                    IdCliente = 2
                },
                Monto = 500,
                idServicio = 30
            }));

            // Console.WriteLine("Hello World!");
        }
    }
}
