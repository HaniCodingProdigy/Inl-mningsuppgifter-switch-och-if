using System;
namespace uppgift3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in det första talet");
            double tal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in det andra talet");
            double tal2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Välj vad du vill göra med dessa två tal");
            Console.WriteLine("1. addition");
            Console.WriteLine("2. subtraktion");
            Console.WriteLine("3. multiplikation");
            Console.WriteLine("4. division");
            string val = Console.ReadLine();
            switch (val)
                {   
                case "1":
                    Console.WriteLine(tal1 + tal2);
                    break;
                case "2":
                    Console.WriteLine(tal1 - tal2);
                    break;
                case "3":
                    Console.WriteLine(tal1 * tal2);
                    break;
                case "4":
                    Console.WriteLine(tal1 / tal2);
                    break;
                default:
                    break;
                }
               

            }

        }
    }



