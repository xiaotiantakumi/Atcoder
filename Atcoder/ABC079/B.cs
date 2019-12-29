using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC079
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            Queue<long> queue = new Queue<long>();
            int counter = 0;
            while (counter != N)
            {
                if (counter == 0)
                {
                    queue.Enqueue(2);
                }
                else if (counter == 1)
                {
                    queue.Enqueue(1);
                }
                else
                {
                    queue.Enqueue(queue.Sum());
                    queue.Dequeue();
                }
                counter++;
            }
            Console.WriteLine(queue.Sum());
        }
    }
}