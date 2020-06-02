using System;
using System.Linq;

namespace Atcoder.ABC.ABC169
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            long limit = 1000000000000000000;
            var N = int.Parse(Console.ReadLine());
            var As = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            long ret = 1;
            if (As[0] == 0)
            {
                Console.WriteLine(0);
                return;
            }

            try
            {
                checked
                {

                    for (int i = 0; i < N; i++)
                    {
                        ret *= As[i];
                    }

                    if (ret > limit) throw new Exception();
                    Console.WriteLine(ret);
                }
            }
            catch
            {
                Console.WriteLine(-1);
            }
        }
    }
}