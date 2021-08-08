using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your Name: ");
            string name = Console.ReadLine();
            Console.Write("Your Country: ");
            string country = Console.ReadLine();
            Console.Write("Your Age: ");
            string age = Console.ReadLine();
            Console.Write("How Are You?: ");
            string howIsyou = Console.ReadLine();

            Console.WriteLine("My Name Is " + name + ", And I Am " + age + " And I Am From " + country + " And I Am " + howIsyou );
            Console.WriteLine("Nice To Meet You, " + name + " And I Was Created By A YouTuber Called Ckmk Ahmet, His Name is Ahmet :).");

        }

    }

}
