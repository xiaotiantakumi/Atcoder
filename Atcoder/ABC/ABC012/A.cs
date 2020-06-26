using System;
using System.Linq;

namespace Atcoder.ABC.ABC012
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var AB = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(AB[1] + " " + AB[0]);
        }
    }
}