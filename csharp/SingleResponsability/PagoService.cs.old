using System;
using System.Text;

namespace csharp
{
    public class PagoService
    {
        public string Registrar(int idCliente, decimal monto, int idServicio) {
            bool esValido = true;
            StringBuilder message = new StringBuilder();
            message.Append($"Iniciando proceso para cliente: {idCliente}" + Environment.NewLine);

            if (!ValidarClienteActivo(idCliente)) {
                message.Append("El pago no puede ser registrado debido a que el cliente no esta activo" + Environment.NewLine);
                esValido = false;
            }

            if (monto <= 0) {
                message.Append("El pago no puede ser registrado debido a que el monto no es mayor a cero" + Environment.NewLine);
                esValido = false;
            }

            if (esValido)
                message.Append($"El pago fue registrado correctamente par el codigo de servicio: {idServicio}" + Environment.NewLine);

            message.Append("Fin del proceso" + Environment.NewLine);
            return message.ToString();
        }

        public bool ValidarClienteActivo(int idCliente) {
            if (idCliente != 0) {
                return true;
            }
            return false;
        }
    }
}
