using System;
using System.Linq;

namespace Atcoder.ABC046
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ret = 3;
            if (r[0] == r[1]) ret--;
            if (r[1] == r[2]) ret--;
            if (r[0] == r[2]) ret--;
            if (ret == 0)
            {
                ret++;
            }
            Console.WriteLine(ret);
        }
    }
}