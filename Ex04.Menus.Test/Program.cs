using System;
using System.Threading;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Menu implemented by delegates.");
            DelegatesTests delegatesTests = new DelegatesTests();
            delegatesTests.RunTests();

            Console.Clear();
            Console.WriteLine("Welcome to the Menu implemented by interfaces.");
            InterfacesTests InterfacesTest = new InterfacesTests();
            InterfacesTest.RunTests();
        }
    }
}
