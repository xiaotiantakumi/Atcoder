using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC059
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var r = ReadStringArray();
            string ret = string.Empty;
            foreach (var s in r)
            {
                ret += s.First().ToString().ToUpper();
            }

            Console.WriteLine(ret);
        }
    }
}