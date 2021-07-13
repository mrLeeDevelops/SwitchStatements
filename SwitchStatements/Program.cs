using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");
            var response = Console.ReadLine();

            switch (response)
            {
                case "Math":
                    Console.WriteLine($"{response} is cool!");
                    break;

                case "Science":
                    Console.WriteLine($"{response} is cool. There are so many types of {response}.");
                    break;

                case "English":
                    Console.WriteLine($"If only I could read {response}, then I would know what your response is. :-)");
                    break;

                default:
                    Console.WriteLine($"{response} huh? Never heard of that one but I'm sure it's cool!");
                    break;
            }
        }
    }
}
