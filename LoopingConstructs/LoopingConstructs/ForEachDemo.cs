using System;


namespace LoopingConstructs
{
    // This program shows how to write foreach loop
    class ForEachDemo
    {
        static void Main()
        {
           
            int[] numsArray = {11,22,33,44,55 };
            int sum = 0;
            foreach(var temp in numsArray)
            {
                sum = sum + temp;
                Console.WriteLine(sum);
            }
            Console.WriteLine("-------Using For Loop---------------");
            for(int i= 0;i<=4; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.ReadLine();
        }
    }
}
