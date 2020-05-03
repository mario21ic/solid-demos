using System;

namespace InterfaceSegregation
{
    public class Paloma : IAve
    {
        public void caminar()
        {
            Console.WriteLine("Puede caminar");
        }

        public void comer()
        {
            Console.WriteLine("Puede comer");
        }

        public void nadar()
        {
            throw new NotImplementedException();
        }

        public void volar()
        {
            Console.WriteLine("Puede volar");
        }
    }
}%   