using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC063
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var r = ReadIntArray().Sum();
            Console.WriteLine(r < 10 ? r.ToString() : "error");
        }
    }
}