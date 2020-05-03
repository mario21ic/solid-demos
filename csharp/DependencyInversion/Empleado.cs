using System;

namespace DependencyInversion
{
    public class Empleado
    {
        private Email _email;
        private SMS _sms;

        public Empleado(Email email, SMS sms) {
            _email = email;
            _sms = sms;
        }

        public void Send() {
            _email.EnviarEmail();
            _sms.EnviarSMS();
        }
    }
}