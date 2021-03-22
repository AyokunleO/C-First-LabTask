using System;

namespace LabTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            
            int[] num = new int[5];
            for( i = 0; i < 5; i++){
               Console.WriteLine($"Enter No {i+1}"); 
              num[i] = int.Parse(Console.ReadLine());
            }

         Array.Sort(num);
         
         foreach(int numArr in num){
          Console.Write($"{numArr} ");
         }  
         }
        
        
    }
} 
