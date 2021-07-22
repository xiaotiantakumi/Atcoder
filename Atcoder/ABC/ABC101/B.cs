using System;
using CoderCommon;

namespace Atcoder.ABC101
{
    public class B : CoderBase
    {
        public override void Run()
        {
            int sum = 0;
            var N = Console.ReadLine();
            foreach (var n in N)
            {
                sum += int.Parse(n.ToString());
            }

            if (int.Parse(N) % sum == 0)
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