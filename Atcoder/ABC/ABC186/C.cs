using System;
using System.Collections.Generic;
using CoderCommon;

namespace Atcoder.ABC.ABC186
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            HashSet<int> items = new HashSet<int>();
            for (int i = 1; i <= N; i++)
            {
                var tenVal = i.ToString();
                if (tenVal.Contains("7"))
                {
                    items.Add(i);
                }
                var eightVal = Convert.ToString(i, 8);
                if (eightVal.Contains("7"))
                {
                    items.Add(i);
                }
            }

            Console.WriteLine(N - items.Count);
        }
    }
}