using System;
using System.Collections.Generic;

namespace Atcoder.ABC154
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var N = ReadInt();
            var r = ReadIntArray();
            List<int> inputList = new List<int>();

            for (int i = 0; i < N; i++)
            {
                var item = r[i];
                if (inputList.Contains(item))
                {
                    Console.WriteLine("NO");
                    return;
                }
                inputList.Add(item);
            }
            Console.WriteLine("YES");
        }
    }
}