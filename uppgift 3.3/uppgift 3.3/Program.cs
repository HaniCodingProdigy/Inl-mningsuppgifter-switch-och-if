using System;
namespace uppgift3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur länge vill du hyra bilen, i timmar");
            int timmar = int.Parse(Console.ReadLine());
            int summa = timmar * 80;
            if (summa >= 950)
            {
                Console.WriteLine("Din kostand är 950kr");
            }
            else
            {
                Console.WriteLine("Din kostnad är " + summa + "kr");
            }
        }
    }
}