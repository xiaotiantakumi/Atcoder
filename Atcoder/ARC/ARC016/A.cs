using System;
using System.Linq;

namespace Atcoder.ARC.ARC016
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 1; i <= NM[0]; i++)
            {
                if (i != NM[1])
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }
    }
}