using System;

namespace prrprrprov53AC
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frågor = { "Vad heter Johan?", "Vad heter Zacharias?", "Vad heter Alex?", "Vad heter Ernst?" };
            string[] svar = {"Johan", "Zacharias", "Alex", "Ernst"};
            
            Console.WriteLine("Vilken fråga från 1 till 4 vill du svara på?");
            int val = int.Parse(Console.ReadLine());
            Console.WriteLine(frågor[val]);
            string svaret = Console.ReadLine().ToUpper;
            if (svaret == svar[val])
            {
                Console.WriteLine("Du svarade rätt");
            }
            else
            {
                Console.WriteLine("Du svarade fel");
                Console.WriteLine("Rätt svar var " + svar[val]);
            }
            for (int i = 0; i<frågor.Length; i++)
            {
                Console.WriteLine(frågor[i]);
                Console.WriteLine(svar[i]);
            }
            


        }
    }
}
