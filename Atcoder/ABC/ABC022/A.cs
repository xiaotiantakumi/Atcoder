using System;
using System.Linq;

namespace Atcoder.ABC.ABC022
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var NST = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int val = 0;
            int ret = 0;
            for (int i = 0; i < NST[0]; i++)
            {
                val += int.Parse(Console.ReadLine());
                if (val >= NST[1] && val <= NST[2])
                {
                    ret++;
                }
            }

            Console.WriteLine(ret);
        }
    }
}