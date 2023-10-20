using System;

namespace övning3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du? (år)");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder > 15 && ålder < 20)
            {
                Console.WriteLine("Du får delta i tävlingen");
            }
            else
            {
                Console.WriteLine("Du får INTE delta i tävlingen");
            }
        }
    }
}