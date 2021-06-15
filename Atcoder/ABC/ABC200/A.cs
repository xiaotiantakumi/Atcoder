using System;

namespace Atcoder.ABC.ABC200
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var ret = (N / 100) + (N % 100 == 0 ? 0 : 1);
            Console.WriteLine(ret);
        }
    }
}