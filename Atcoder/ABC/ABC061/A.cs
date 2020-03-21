using System;

namespace Atcoder.ABC061
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var r = ReadIntArray();
            if (r[0] <= r[2] && r[1] >= r[2])
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}