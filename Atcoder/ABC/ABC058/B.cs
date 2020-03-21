using System;
using System.Linq;

namespace Atcoder.ABC058
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var O = Read();
            var E = Read();
            string ret = string.Empty;
            for (int i = 0; i < E.Length; i++)
            {
                ret += O[i].ToString() + E[i].ToString();
            }

            if (O.Length != E.Length)
            {
                ret += O.Last().ToString();
            }

            Console.WriteLine(ret);
        }
    }
}