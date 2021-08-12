using System;


namespace LoopingConstructs
{
    class Program
    {
        //  This program shows how to use for loop.
        static void Main(string[] args)
        {
            // To sum of numbers from 1 to 15 using for loop
            int sum = 0;
            for(int counter=1;counter<=15;counter++)
            {
                sum = sum + counter;
                Console.WriteLine(sum);
            }
            Console.ReadLine();
        }
    }
}
