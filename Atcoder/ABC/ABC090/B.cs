using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC090
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var l = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var A = l[0];
            var B = l[1];
            int count = 0;
            for (int i = A; i <= B; i++)
            {
                var checkTarget = i.ToString().ToCharArray();
                if (checkTarget[0] == checkTarget[4] &&
                    checkTarget[1] == checkTarget[3])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}