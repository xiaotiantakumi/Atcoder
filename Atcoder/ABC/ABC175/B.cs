using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC175
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var Ls = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
            int ret = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (Ls[i] == Ls[j])
                    {
                        continue;
                    }
                    for (int k = j + 1; k < N; k++)
                    {
                        if (Ls[i] == Ls[k] || Ls[j] == Ls[k])
                        {
                            continue;
                        }

                        if (Ls[i] + Ls[j] > Ls[k] &&
                            Ls[j] + Ls[k] > Ls[i] &&
                            Ls[k] + Ls[i] > Ls[j])
                        {
                            ret++;
                        }
                    }
                }
            }

            Console.WriteLine(ret);
        }
    }
}