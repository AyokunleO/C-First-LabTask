using System;

namespace LabTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter Your Name:");
            var name = Console.ReadLine();

            Console.WriteLine("Enter Your Age:");
            var age = int.Parse(Console.ReadLine());

            var userInfo = GetInfo(name, age);
            Console.WriteLine($"{userInfo}");
        }

        static string GetInfo(string name, int age)
        {
            var user = $"Your name is {name} and your age is {age}";
            return user;
        }
    }
}
