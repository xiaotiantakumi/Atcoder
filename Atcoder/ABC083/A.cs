using System;
using System.Linq;

namespace Atcoder.ABC083
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (r[0] + r[1] > r[2] + r[3])
            {
                Console.WriteLine("Left");
            }
            else if (r[0] + r[1] < r[2] + r[3])
            {
                Console.WriteLine("Right");
            }
            else
            {
                Console.WriteLine("Balanced");
            }
        }
    }
}