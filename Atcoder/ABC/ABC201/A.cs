using System;
using System.Linq;

namespace Atcoder.ABC.ABC201
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var ABC = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
            var A = ABC[0];
            var B = ABC[1];
            var C = ABC[2];
            var diff1 = C - B;
            var diff2 = B - A;

            if (diff2 == diff1)
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