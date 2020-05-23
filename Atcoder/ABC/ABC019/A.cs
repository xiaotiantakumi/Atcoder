using System;
using System.Linq;

namespace Atcoder.ABC.ABC019
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var abc = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
            Console.WriteLine(abc[1]);
        }
    }
}