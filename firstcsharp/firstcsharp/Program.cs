using System;

namespace c__
{

    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            int divisor = 0;


            for(int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                    divisor++;
                }
            }


            if (divisor == 2)
            {
                Console.WriteLine("The number you enter is a prime number ");
            }

            else
            {
                Console.WriteLine("The number you enter is a composite number");
            } 
        }
    }
}

