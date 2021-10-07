using System;

namespace SubstituteCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm asendab kõik 'a' tähed kasutajanimes tärninga (*)
            //programm kuvab tulemust konsoolis

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();
            string fullName = $"{firstName} {lastName}";

            fullName = fullName.Replace('a', '*');

            Console.WriteLine(fullName);

        }
    }
}
