using System;
using System.Linq;

namespace Atcoder.ABC152
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (r[0] < r[1])
            {
                for (int i = 0; i < r[1]; i++)
                {
                    Console.Write(r[0]);
                }

            }
            else
            {
                for (int i = 0; i < r[0]; i++)
                {
                    Console.Write(r[1]);
                }
            }
        }
    }
}