using System;

namespace LabTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string user = Console.ReadLine();
            string userFirst = $"{user[0]}";
            Console.WriteLine($"Your Name starts with {userFirst}");
        }
    }
}
