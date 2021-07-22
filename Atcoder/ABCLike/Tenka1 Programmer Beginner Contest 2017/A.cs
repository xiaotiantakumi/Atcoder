using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABCLike.Tenka1_Programmer_Beginner_Contest_2017
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var S = Console.ReadLine();
            Console.WriteLine(S.Count(x => x == '1'));
        }
    }
}