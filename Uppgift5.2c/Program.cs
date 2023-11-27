using System;
namespace uppgift5._2c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många tal vill du skriv in?");
            string antaltext = Console.ReadLine();
            int antal = int.Parse(antaltext);
            string[] tal = new string[antal];
            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine("Skriv in ett tal");
                tal[i] = Console.ReadLine();
            }
            int count  = 0;
            for (int i = 0;i < antal; i++)
            {
                count++;
                Console.WriteLine("tal " + count + ": " + tal[i]);
            }
        }
    }
}