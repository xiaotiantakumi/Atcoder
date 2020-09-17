using System;
using System.Linq;

namespace Atcoder.ABCLike.Tenka1_Programmer_Beginner_Contest_2017
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var S = Console.ReadLine();
            Console.WriteLine(S.Count(x => x == '1'));
        }
    }
}