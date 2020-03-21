using System;
using System.Linq;

namespace Atcoder.ABC152
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (r[0] == r[1])
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