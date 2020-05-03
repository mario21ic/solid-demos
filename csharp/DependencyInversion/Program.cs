using System;
using System.Collections.Generic;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            IMensaje email = new Email(){
                Subject = "mario@gmail.com"
            };
            IMensaje sms = new SMS(){
                Numero = "966396646"
            };

            List<IMensaje> listMensaje = new List<IMensaje>();
            listMensaje.Add(email);
            listMensaje.Add(sms);

            Empleado empleado = new Empleado(listMensaje);
            empleado.Send();
        }
    }
}
