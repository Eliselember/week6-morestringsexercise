using System;

namespace MorestringsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab sõna "racecar" tagurpidi
            //*kasutame for-tsüklit

            string RaceC = "racecar";

            for (int i = RaceC.Length - 1; i >= 0; i--)
            {
                Console.Write(RaceC[i]);
            }
        }
    }
}
