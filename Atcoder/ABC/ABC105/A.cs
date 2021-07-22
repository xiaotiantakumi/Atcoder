using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC105
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (input[0] % input[1] == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }
        }
    }
}