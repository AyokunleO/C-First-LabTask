using System;

namespace LabTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2");
            var num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number 1(+), 2(-), 3(/), 4(*), 5(++), 6(--)");
            var arith = int.Parse(Console.ReadLine());

            int calc = 0;
            switch (arith)
            {
                case 1:
                calc = num1 + num2;
                break;

                case 2:
                calc = num1 - num2;
                break;

                case 3:
                calc = num1 / num2;
                break;

                case 4:
                calc = num1 * num2;
                break;

                case 5:
                calc = (num1 + num2) + 1;
                break;

                case 6:
                calc = (num1 - num2) - 1;
                break;

                default:
                Console.WriteLine("Enter a valid input");
                break;
            }
            Console.WriteLine($"{calc}");
        }
    }
}
