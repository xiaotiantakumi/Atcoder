using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC041
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var ABC = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var ret = ((ABC[0] * ABC[1]) % COMDIV) * ABC[2] % COMDIV;
            Console.WriteLine(ret);
        }
    }
}