using System;

namespace LabTask7
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 3; i++){
            Console.WriteLine("Enter hourly rate for employee:");
            var empRt= float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the hours worked for employee:");
            var empHr = float.Parse(Console.ReadLine());

            Console.WriteLine($"Pay for employee {i} is: ${empRt * empHr}");
            }

        }
    }
}
