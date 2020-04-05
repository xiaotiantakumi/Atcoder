using System;
using System.Linq;

namespace Atcoder.ABC.ABC161
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var As = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToArray();
            var cond = (double)As.Sum() / (double)(NM[1] * 4);
            int count = 0;
            for (int i = 0; i < NM[0]; i++)
            {
                if (As[i] >= cond)
                {
                    count++;
                }
            }
            if (count >= NM[1])
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