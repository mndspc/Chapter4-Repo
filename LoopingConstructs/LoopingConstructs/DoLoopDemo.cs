using System;

namespace LoopingConstructs
{
    //  This shows how to write do-while-loop construct
    class DoLoopDemo
    {
        static void Main()
        {
            // To sum of numbers from 1 to 15 using do-while loop
            int counter = 16;
            int sum = 0;
            do
            {
                sum = sum + counter;
                Console.WriteLine(sum);
                counter++;
            } while (counter<=15);
            Console.ReadLine();
        }
    }
}
