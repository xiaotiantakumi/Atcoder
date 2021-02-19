using System;
using System.Linq;

namespace Atcoder.ABC.ABC187
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var AB = Console.ReadLine().Split();
            int A = AB[0].Select(x => int.Parse(x.ToString())).Sum();
            int B = AB[1].Select(x => int.Parse(x.ToString())).Sum();

            Console.WriteLine(Math.Max(A, B));
        }
    }
}