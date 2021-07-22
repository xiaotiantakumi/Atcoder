using System;
using CoderCommon;

namespace Atcoder.ABC158
{
    public class A : CoderBase
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