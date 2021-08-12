using System;


namespace LoopingConstructs
{
    // This program shows how to write while loop construct.
    class WhileLoopDemo
    {
        static void Main()
        {
            // To sum of numbers from 1 to 15 using while- loop
            int counter = 1;
            int sum = 0;
            while (counter <= 15)
            {
                sum = sum + counter;
                Console.WriteLine(sum);
                counter++;
            }
            Console.ReadLine();
        }
    }
}
