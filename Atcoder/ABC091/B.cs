using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC091
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            Dictionary<string, int> valList = new Dictionary<string, int>();
            for (int i = 0; i < N; i++)
            {
                var s = Console.ReadLine();
                if (valList.ContainsKey(s))
                {
                    valList[s]++;
                }
                else
                {
                    valList.Add(s, 1);
                }
            }
            var M = int.Parse(Console.ReadLine());
            for (int i = 0; i < M; i++)
            {
                var s = Console.ReadLine();
                if (valList.ContainsKey(s))
                {
                    valList[s]--;
                }
                else
                {
                    valList.Add(s, -1);
                }
            }

            if (valList.Values.Max() >= 0)
            {
                Console.WriteLine(valList.Values.Max());

            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}