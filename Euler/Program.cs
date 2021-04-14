using System;

namespace Euler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public static bool IsPrime(int n)
        {          
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;                
            }

            return true;           
        }           
        
        public static long SumPrime(long max)
        {
            
            long sum = 0;
            int count = 2;
            while(count < max)
            {
                if (IsPrime(count)) sum += count;
                count++;
            }
            return sum;
        }

        public static int SumOfSquareNumbers(int max)
        {
            int sum = 0;
            for(int i = 1; i <= max; i++)
            {
                sum += (int)Math.Pow(i, 2);
            }
            return sum;
        }

        public static int SquareOfTotal(int max)
        {
            int sum = 0;
            
            for (int i = 1; i <= max; i++)
            {
                sum += i;
                
            }
            int square = (int)Math.Pow(sum, 2);
            return square;
        }

        public static int DifferenceOfSumSquares(int max)
        {
            int difference = SquareOfTotal(max) - SumOfSquareNumbers(max);
            return difference;
        }
        
        public static int SumOfMultiples(int max)
        {
            int sum = 0;
            for(int i = 1; i < max; i++)
            {
                if(i % 5 == 0 || i % 3 == 0) sum += i;
            }
            return sum;
        }

      
    }
}
