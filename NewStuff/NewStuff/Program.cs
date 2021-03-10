using System;

namespace NewStuff
{
    /// <summary>
    /// This program is a simple start to a calculator with different math functions
    /// </summary>
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Lommeregner");
        }
        // adds two numbers together
        static int plus(int tal1, int tal2)
        {
            int resultat = tal1 + tal2;

            return resultat;
        }
        // subtract two numbers 
        static int minus(int tal1, int tal2)
        {
            int resultat = tal1 + tal2;

            return resultat;
        }
        // Multipli two numbers togéther
        static int gange(int tal1, int tal2)
        {
            int resultat = tal1 * tal2;

            return resultat;
        }
        // Divide two numbers
        static int dividere(int tal1, int tal2)
        {
            int resultat = tal1 / tal2;

            return resultat;
        }
    }

}
