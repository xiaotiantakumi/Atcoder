using System;
using System.Linq;

namespace Atcoder.ABC059
{
    public class A : AtcoderBase
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