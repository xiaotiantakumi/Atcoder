using System;

namespace Atcoder.ABC079
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var N = Console.ReadLine();


            if (N[0] == N[1] && N[0] == N[2] ||
                N[1] == N[2] && N[1] == N[3])
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