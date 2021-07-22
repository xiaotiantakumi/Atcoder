using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ARC.ARC007
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] ret = new int[NM[0] + 1];
            for (var index = 0; index < ret.Length; index++)
            {
                ret[index] = index;
            }

            for (int i = 0; i < NM[1]; i++)
            {
                var inp = int.Parse(Console.ReadLine());
                var tmp = ret[0];
                int index = 0;
                for (int j = 0; j < ret.Length; j++)
                {
                    if (ret[j] == inp)
                    {
                        index = j;
                    }
                }
                ret[0] = ret[index];
                ret[index] = tmp;
            }

            Console.WriteLine(string.Join("\n", ret.Skip(1)));
        }
    }
}