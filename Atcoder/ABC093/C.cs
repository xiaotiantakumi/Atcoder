using System;
using System.Linq;

namespace Atcoder.ABC093
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
            int ret = 0;
            while (r[0] != r[1] || r[0] != r[2])
            {
                if (r[0] == r[1])
                {
                    ret += r[2] - r[0];
                    break;
                }
                else
                {
                    ret++;
                    r[0] += 2;
                    r = r.OrderBy(x => x).ToArray();
                }
            }
            Console.WriteLine(ret);
        }
    }
}