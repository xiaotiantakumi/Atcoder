using System;
using System.Linq;

namespace Atcoder.ABC097
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var f = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if ((Math.Abs(f[1] - f[0]) <= f[3] &&
                 Math.Abs(f[2] - f[1]) <= f[3]) ||
                Math.Abs(f[2] - f[0]) <= f[3])
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}