using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC159
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var S = Console.ReadLine().ToCharArray();
            var N = S.Length;
            var ret = S.Zip(S.Reverse(), (x, y) => x == y).All(x => x);
            if (!ret)
            {
                Console.WriteLine("No");
                return;
            }
            var cond2 = S.Take((N - 1) / 2).ToArray();
            ret = cond2.Zip(cond2.Reverse(), (x, y) => x == y).All(x => x);
            if (!ret)
            {
                Console.WriteLine("No");
                return;
            }
            Console.WriteLine("Yes");
        }
    }
}