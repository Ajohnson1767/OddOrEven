using System;

namespace OddOrEven
{
    class Program
    {

        static void Main(string[] args)
        {
            bool answer = IsOdd(5);

            Console.WriteLine(answer);
            
        }
        //Start Here
        public static bool IsOdd(int num)
        {


            //Determines if a number is odd
            if (num % 2 == 0)
            {

                Console.WriteLine("Number is even");
                return false;
                
            }
            else
            {
                Console.WriteLine("Number is odd");
                return true;
                
            }

        }

    }
}
