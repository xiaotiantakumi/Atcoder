using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC213
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var r = Console.ReadLine().Split().Select(int.Parse).ToList();
            var tar = r.OrderByDescending(x => x).ToArray().Skip(1).Take(1).First();
            Console.WriteLine(r.IndexOf(tar) + 1);
        }
    }
}