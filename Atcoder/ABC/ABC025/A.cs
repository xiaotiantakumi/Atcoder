using System;
using System.Collections.Generic;
using CoderCommon;

namespace Atcoder.ABC.ABC025
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var S = Console.ReadLine();
            var N = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    list.Add(S[i].ToString() + S[j].ToString());
                }
            }

            Console.WriteLine(list[N - 1]);
        }
    }
}