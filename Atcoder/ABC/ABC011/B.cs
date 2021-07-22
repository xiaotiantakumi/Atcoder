using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC011
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var S = Console.ReadLine();
            var ret = new string(S.ToUpper().Take(1).ToArray()) + new string(S.Skip(1).ToArray()).ToLower();
            Console.WriteLine(ret);
        }
    }
}