using System;
namespace uppgift3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många minuter lång är låten");
            int minuter = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många sekunder lång är låten");
            int sekunder = int.Parse(Console.ReadLine());
            if (minuter > 4 || minuter >= 4 && sekunder > 20 || minuter < 2 || minuter <= 2 && sekunder < 45)
            {
                Console.WriteLine("Din låt kan inte spelas i radiostationen");
            }
            else
            {
                Console.WriteLine("Din låt kan spelas i radiotstationen");
            }
        }
    }
}