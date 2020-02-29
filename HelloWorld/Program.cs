using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which dialect do you prefer?");
            foreach(string arg in args)
            {
                Console.WriteLine(arg);
            }
            var answer = Console.ReadLine().ToLower().Trim();

            switch (answer)
            {
                case "northern":
                    Console.WriteLine("Hey guys!");
                    break;
                case "foreign":
                    Console.WriteLine("Hei! Hau doss it go?");
                    break;
                default:
                    Console.WriteLine("Howdy, y'all!");
                    break;
            }
                //Console.ReadKey(); // What happens if you run the app without this line?

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Dog", "Snake" };
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'y' };

            foreach (var animal in animals)
            {
                var lowerCaseAnimal = animal.ToLower().Trim();
                var lastWasVowel = false;
                var count = 0;

                foreach(var c in lowerCaseAnimal)
                {
                    if(vowels.Contains(c) && !lastWasVowel)
                    {
                        count++;
                        lastWasVowel = true;
                    }
                    else
                    {
                        lastWasVowel = false;
                    }
                }

                if ((lowerCaseAnimal.EndsWith("e") || (lowerCaseAnimal.EndsWith("es") || lowerCaseAnimal.EndsWith("ed"))) && !lowerCaseAnimal.EndsWith("le"))
                    count--;
                if (count > 1)
                {
                    Console.WriteLine(animal);
                }
            }

            Console.ReadLine();
        }
    }
}
