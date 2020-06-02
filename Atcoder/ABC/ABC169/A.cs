using System;
using System.Linq;

namespace Atcoder.ABC.ABC169
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var AB = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(AB[0] * AB[1]);
        }
    }
}