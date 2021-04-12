using System;
using System.Linq;

namespace Atcoder.ABC.ABC189
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var NX = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < NX[0]; i++)
            {
                var VP = Console.ReadLine().Split().Select(int.Parse).ToArray();
                sum += VP[0] * VP[1];
                if (sum > NX[1] * 100)
                {
                    Console.WriteLine(i + 1);
                    return;
                }
            }

            Console.WriteLine(-1);
        }
    }
}