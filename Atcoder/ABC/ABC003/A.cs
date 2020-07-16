using System;

namespace Atcoder.ABC.ABC003
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var N = int.Parse(Console.ReadLine());
            decimal ret = 0;
            for (int i = 1; i <= N; i++)
            {
                ret += i;
            }

            Console.WriteLine(ret * 10000 / N);
        }
    }
}