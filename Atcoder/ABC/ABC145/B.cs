using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC145
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var r = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().OrderBy(x => x).ToArray();
            for (int i = 0; i < input.Length; i += 2)
            {
                if (input.Length == 1 || input.Length % 2 == 1 || input[i] != input[i + 1])
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}