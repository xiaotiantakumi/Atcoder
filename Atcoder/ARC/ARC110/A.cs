using System;

namespace Atcoder.ARC.ARC110
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var N = int.Parse(Console.ReadLine());
            long ret = 2;
            for (long i = 3; i <= N; i++)
            {
                ret = Lcm(ret, i);
            }
            Console.WriteLine(ret + 1);
        }
    }
}