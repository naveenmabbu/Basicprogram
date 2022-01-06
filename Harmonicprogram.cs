using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicNumber
{
    internal class Program
    {
         public void FindHarmonicSeries()
        {
            Console.WriteLine("Welcome to Harmonic series");

            int Num;
            Console.WriteLine("Enter Number till you want to print Harmonic series: ");
            Num = Convert.ToInt32(Console.ReadLine());
            double sumofHarmonicSeries = 0.0;

            for (int i = 1; i <= Num; i++)
            {

                Console.Write("1/{0} +", i);
                sumofHarmonicSeries = sumofHarmonicSeries + 1 / (double)i;

            }

            Console.WriteLine();
            Console.WriteLine("\nSum of series upto {0} terms : {1}\n", +Num, +sumofHarmonicSeries);
            Console.ReadLine();
        }

        static void Main()
        {
            Program harmonic = new Program();
            harmonic.FindHarmonicSeries();
        }
    }
}
