using System;

namespace InterfaceSegregation
{
    public class Paloma : IAve, IAveVolar
    {
        public void caminar()
        {
            Console.WriteLine("Puede caminar");
        }

        public void comer()
        {
            Console.WriteLine("Puede comer");
        }

        public void volar()
        {
            Console.WriteLine("Puede volar");
        }
    }
}  