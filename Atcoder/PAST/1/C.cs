using System;
using System.Linq;

namespace Atcoder.PAST._1
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var array = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToArray();
            Console.WriteLine(array[2]);
        }
    }
}