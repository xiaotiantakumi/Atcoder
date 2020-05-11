using System;
using System.Linq;

namespace Atcoder.ABC.ABC167
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var S = Console.ReadLine();
            var T = Console.ReadLine();
            if (S == new string(T.Take(S.Length).ToArray()))
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