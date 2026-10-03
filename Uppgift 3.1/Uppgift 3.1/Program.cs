using System;
namespace uppgift3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du");
            int ålder = int.Parse(Console.ReadLine());
            if (ålder <= 19 && ålder >= 16) {
                Console.WriteLine("Du får delta i tävlingen");

            }
            else
            {
                Console.WriteLine("Du får inte delta i tävlingen");
            }
        }
    }
}