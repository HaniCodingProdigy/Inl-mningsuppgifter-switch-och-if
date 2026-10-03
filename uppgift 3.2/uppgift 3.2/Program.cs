using System;
namespace uppgift3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet");
            Console.WriteLine("j - Ja");
            Console.WriteLine("n - Nej");
            string student = Console.ReadLine().ToLower();
            Console.WriteLine("Hur gammal är du");
            int ålder = int.Parse(Console.ReadLine());
            if (ålder < 22 && student == "j")
            {
                Console.WriteLine("Vi vill gärna anställa dig");

            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
            }
        }
    }
}