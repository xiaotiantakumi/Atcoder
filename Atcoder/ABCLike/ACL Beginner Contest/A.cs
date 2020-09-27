using System;
using System.Linq;

namespace Atcoder.ABCLike.ACL_Beginner_Contest
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var K = int.Parse(Console.ReadLine());
            var ret = Enumerable.Repeat("ACL", K).ToArray();
            Console.WriteLine(string.Join("", ret));
        }
    }
}