//Curtis Evans - Week 2
//Stuck In A Time Loop

using System;

namespace StuckInATimeLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine((i+1) +" Abracadabra");
            }
        }
    }
}
