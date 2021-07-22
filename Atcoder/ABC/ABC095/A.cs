using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC095
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var S = Console.ReadLine().ToList().Count(x => x == 'o');
            Console.WriteLine(700 + (100 * S));
        }
    }
}