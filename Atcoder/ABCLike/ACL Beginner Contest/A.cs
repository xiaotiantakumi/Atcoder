using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABCLike.ACL_Beginner_Contest
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var K = int.Parse(Console.ReadLine());
            var ret = Enumerable.Repeat("ACL", K).ToArray();
            Console.WriteLine(string.Join("", ret));
        }
    }
}