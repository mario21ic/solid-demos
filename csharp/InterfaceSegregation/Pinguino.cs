using System;

namespace InterfaceSegregation
{
    public class Pinguino : IAve
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
            Console.WriteLine("Puede nadar");
        }

        public void volar()
        {
            
            throw new NotImplementedException();
        }
    }
}%   