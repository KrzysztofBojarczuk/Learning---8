using System;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablica tab = new Tablica();
            try
            {
                int value = tab.getElement(20);
                Console.WriteLine("Element nr 20 ma wartość: " + value);
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Nie ma elementu o numerze 20!");
            }
        }
    }
}
