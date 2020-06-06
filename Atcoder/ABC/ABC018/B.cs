using System;
using System.Linq;

namespace Atcoder.ABC.ABC018
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var S = Console.ReadLine();
            var N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                var lr = Console.ReadLine().Split().Select(x => int.Parse(x) - 1).ToArray();
                var leftPart = S.Substring(0, lr[0]);
                var rightPart = S.Substring(lr[1] + 1);
                var middlePart = new string(S.Substring(lr[0], lr[1] - lr[0] + 1).Reverse().ToArray());
                S = leftPart + middlePart + rightPart;
            }

            Console.WriteLine(S);
        }
    }
}