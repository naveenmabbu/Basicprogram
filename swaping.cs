using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap_number
{
    internal class swaping
    {
        public static void swapingNumbers()
        {
            Console.WriteLine("...Swaping Two Numbers...");
            Console.WriteLine("Enter the First number and Second number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swap FirstNumber= " + firstNumber + " SecondNumber= " + secondNumber);
            firstNumber = firstNumber * secondNumber; //a=50 (5*10)      
            secondNumber = firstNumber / secondNumber; //b=5 (50/10)      
            firstNumber = firstNumber / secondNumber; //a=10 (50/5)
            Console.WriteLine("After Swaping , The numbers are..");
            Console.WriteLine(" FirstNumber= " + firstNumber + " SecondNumber= " + secondNumber);
        }
    }
}
