using System;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab, mitu sõna on lauses "Hello world!"

            string hellow = "Hello world!";

            //while

            int i = 0;
            int wordCounter = 1;
            while (i < hellow.Length)
            {
                if (hellow[i] == ' ')
                {
                    wordCounter++;
                }

                i++;
            }

            Console.WriteLine($"Lauses {hellow} on {wordCounter} sõna");


        }
    }
}
