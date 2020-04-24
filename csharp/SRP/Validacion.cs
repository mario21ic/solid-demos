using System;

namespace csharp
{
    public static class Validacion
    {
        public static ValidacionRespuesta RealizarValidaciones(Modelos.Transaccion transaccion)
        {
            ValidacionRespuesta respuesta = new ValidacionRespuesta();
            respuesta.EsValido = true;

            if (!ValidarClienteActivo(transaccion.Cliente.IdCliente)) {
                respuesta.Mensaje += $"El pago no puede ser registrado debido a que el cliente {transaccion.Cliente.IdCliente} no esta activo" + Environment.NewLine;
                respuesta.EsValido = false;
            }

            if (transaccion.Monto <= 0) {
                respuesta.Mensaje += $"El pago del cliente {transaccion.Cliente.IdCliente} no puede ser registrado debido a que el monto no es mayor a cero" + Environment.NewLine;
                respuesta.EsValido = false;
            }

            return respuesta;
        }

        public static bool ValidarClienteActivo(int idCliente) {
            // Console.WriteLine($"validarCliente IdCliente {idCliente}" + Environment.NewLine);
            if (idCliente != 0) {
                return true;
            }
            return false;
        }
    }
}