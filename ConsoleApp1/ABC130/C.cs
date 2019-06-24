using System;
using System.Linq;

namespace Atcoder.ABC130
{
    public class C : IAtcoder
    {
        public void Run()
        {
            var first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            double W = first[0];
            double H = first[1];
            var x = first[2];
            var y = first[3];

            double minArea = W * H / 2;
            var isMulti = (W / 2 == x) && (H / 2 == y);
            if (isMulti)
            {
                Console.Write(minArea.ToString() + " 1");
            }
            else
            {
                Console.Write(minArea.ToString() + " 0");
            }
        }
    }
}