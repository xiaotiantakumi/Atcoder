using System;
using System.Linq;

namespace Atcoder.ABCLike.CADDi_2018_for_Beginners
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var s = Console.ReadLine();
            Console.WriteLine(s.Count(x => x == '2'));
        }
    }
}