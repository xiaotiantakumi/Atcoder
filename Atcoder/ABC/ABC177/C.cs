using System;
using System.Linq;

namespace Atcoder.ABC.ABC177
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var As = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            decimal sumAs = As.Sum();
            decimal ret = 0;
            for (int i = 0; i < N - 1; i++)
            {
                if (i == N - 2)
                {
                    ret = (ret + As[i] * As[i + 1] % COMDIV) % COMDIV;
                    break;
                }
                sumAs -= As[i];
                ret = (ret + As[i] * sumAs % COMDIV) % COMDIV;
            }

            Console.WriteLine(ret);
        }
    }
}