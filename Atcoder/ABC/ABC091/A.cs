using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC091
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var l = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (l[2] <= l[0] + l[1])
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