using System;
using System.Collections.Generic;

namespace DependencyInversion
{
    public class Empleado
    {
        private List<IMensaje> _mensajes;
        public Empleado(List<IMensaje> mensajes) {
            _mensajes = mensajes;
        }
 

        public void Send() {
            foreach ( var mensaje in _mensajes) {
                mensaje.EnviarMensaje();
            }
        }
    }
}