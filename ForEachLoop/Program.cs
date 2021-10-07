using System;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab sõna "Hello world!" pikkust Length omadust kasutamata
            string hellow = "Hello world!";
            int charCounter = 0;

            foreach (char c in hellow)
            {
                charCounter++;
            }

            Console.WriteLine($"Lause pikkus {hellow} on {charCounter}.");
        }
    }
}
