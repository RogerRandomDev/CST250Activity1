using System;

namespace CountToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.Write("Please enter an integer.  I will do some math and eventually arrive at 1 ");
            int startingNumber = int.Parse(Console.ReadLine());
            int x = countToOne(startingNumber);
            Console.ReadLine();
        }

        static public int countToOne(int number)
        {
            Console.Out.WriteLine("Number is {0}", number);
            if (number == 1)
            {
                return 1;
            }
            else
            {
                if (number % 2 == 0)
                {
                    Console.Out.WriteLine("Number is even. Divide by 2");
                    return countToOne(number / 2);
                }
                else
                {
                    Console.Out.WriteLine("Number is odd.  Add 1");
                    return countToOne(number + 1);
                }
            }
        }
    }
}
