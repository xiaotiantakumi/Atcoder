using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC098
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            var array = new List<int>();
            int count = S.Skip(1).Count(x => x == 'E');
            array.Add(count);
            for (int i = 1; i < N; i++)
            {
                if (S[i] == 'E') --count;
                if (S[i - 1] == 'W') ++count;
                array.Add(count);
            }

            Console.WriteLine(array.Min());
        }
    }
}