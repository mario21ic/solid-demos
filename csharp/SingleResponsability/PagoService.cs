using System;
using System.Text;

namespace csharp
{
    public class PagoService
    {
        public string Registrar(Modelos.Transaccion transaccion)
        {
            StringBuilder message = new StringBuilder();
            message.Append($"Iniciando proceso para cliente: {transaccion.Cliente.IdCliente}" + Environment.NewLine);

            ValidacionRespuesta respuesta = Validacion.RealizarValidaciones(transaccion);
            if (respuesta.EsValido) {
                message.Append($"El pago del cliente {transaccion.Cliente.IdCliente} fue registrado correctamente para el codigo de servicio: {transaccion.idServicio}" + Environment.NewLine);
            } else {
                message.Append(respuesta.Mensaje);
            }
            
            message.Append("Fin del proceso" + Environment.NewLine);
            return message.ToString();
        }

    }
}
