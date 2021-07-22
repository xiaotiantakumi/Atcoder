using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABCLike.CADDi_2018_for_Beginners
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var s = Console.ReadLine();
            Console.WriteLine(s.Count(x => x == '2'));
        }
    }
}