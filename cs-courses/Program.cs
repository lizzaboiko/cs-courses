using System;

namespace dezeshka1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();

            Console.WriteLine("Enter your lastname:");
            var lastname = Console.ReadLine();

            Console.WriteLine("Enter your birth year:");
            var birthyear = int.Parse(Console.ReadLine());

            var age = DateTime.Now.Year - birthyear;

            Console.WriteLine("Hello, " + name + " " + lastname + "! Your age is " + age);
        }
    }
}
