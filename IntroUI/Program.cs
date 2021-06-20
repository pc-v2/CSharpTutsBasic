using System;
using IntroLibrary;
namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel
            {
                FirstName = "Jerry",
                LastName = "Shaw"
            };
            System.Console.WriteLine($"{person.FirstName} {person.LastName} is my name");
            
            Console.WriteLine("Hello World!");
            Console.WriteLine("fuck you!");
        }
    }
}
