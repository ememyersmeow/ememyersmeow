using System;

namespace myers
{
    internal class Program
    {
        static int age = 16;
        static string name = "Myers";
        static string country = "Russia";

        static string github = "https://github.com/ememyersmeow";

        static string[] skills = { "C#", "Python", "Unity" };

        public static void Main(string[] args)
        {
            Console.WriteLine("Hey! I'm " + name);
            Console.WriteLine("I'm " + age + " years old");
            Console.WriteLine("And I live in " + country + "\n");

            Console.WriteLine("You can find my projects");
            Console.WriteLine("and information about me at " + github + "\n");

            Console.WriteLine("My skills:");
            for (int i = 0; i < skills.Length; i++)
            {
                Console.WriteLine("- " + skills[i]);
            }
        }

        public static void myers()
        {
            Program.myers();
        }
    }
}