using System;

namespace LabTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int small = 0;
            int[] num = new int[5];
            for( i = 0; i < 5; i++){
               Console.WriteLine($"Enter No {i+1}"); 
            num[i] = int.Parse(Console.ReadLine());    
            }
            small = num[0];

            for(i = 1; i < 5; i++){
                if(small > num[i]){
                    small = num[i];
                }
            }
            Console.WriteLine($"Smallest number is {small}");
            
        }
    }
}
