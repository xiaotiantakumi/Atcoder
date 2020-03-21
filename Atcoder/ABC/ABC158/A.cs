using System;

namespace Atcoder.ABC158
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var S = Read();
            if (S[0] == S[1] && S[1] == S[2])
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}