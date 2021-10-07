using System;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimi ja perekonnanimi
            //programm kuvab kasutaja eesnime ja perekonnanime pikkust kokku
            //Length omadust kasutamata

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName} {lastName}";
            int charcounter = 0;

            foreach (char c in fullName)
            {
                charcounter++;
            }

            Console.WriteLine(charcounter);

        }
    }
}
