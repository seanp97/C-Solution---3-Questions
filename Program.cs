using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace ConsoleApplicationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Questions q = new Questions();

            // Lorem Ipsum
            int y = q.CounterGeneric<string, char>("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Eanean sodales justo et Enim ornare, a congue lacus commodo", 'e');
            Console.WriteLine(y);

            //Number value count
            int z = q.CounterGeneric<string, int>("17272838119191929838299111", 1);
            Console.WriteLine(z);


            //Add nums
            int a = q.AddNums(7, 5);
            Console.WriteLine(a);

        }

    }


}
