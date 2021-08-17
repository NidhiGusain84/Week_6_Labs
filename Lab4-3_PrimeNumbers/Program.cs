using System;

namespace Lab4_3_PrimeNumbers
{   
    class Program
    {
        
        static void Main(string[] args)
        {
          
            Console.WriteLine("Let's locate some primes!\n");
            Console.WriteLine("This application will find you any prime, in order, from first prime number on.\n");

            do
            {
                Console.Write("Which prime number are you looking for?: ");
                int.TryParse(Console.ReadLine(), out int num);

                Console.WriteLine($"\nThe number {num} prime is {PrimeNumbers.GetPrime(num)}");
               string userResponse = Continue();
                if (userResponse == "y")
                {
                    Console.WriteLine();
                    continue;
                }
                else
                {
                    Console.WriteLine("\nGoodbye!");
                    break;
                }

            } while (true);

        }


        public static string Continue()
        {
            Console.Write("\nDo you want to find another prime number? (y/n): ");
            string choice = Console.ReadLine().ToLower();
            while (choice != "y" && choice != "n")
            {
                Console.Write("\nEnter y or n: ");
                choice = Console.ReadLine().ToLower();
            }
            return choice;
        }


    }
}

