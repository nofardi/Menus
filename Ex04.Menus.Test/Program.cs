using System;
using System.Threading;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Menu implemented by delegates.");
            Thread.Sleep(2000);
            DelegatesTests delegatesTests = new DelegatesTests();
            delegatesTests.RunTests();

            Console.Clear();
            Console.WriteLine("Welcome to the Menu implemented by interfaces.");
            Thread.Sleep(2000);
            InterfacesTest InterfacesTest = new InterfacesTest();
            InterfacesTest.RunTests();
        }
    }
}
