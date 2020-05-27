using System;
using System.Collections.Generic;

namespace Atcoder.PAST._1
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            List<int> items = new List<int>();
            for (int i = 0; i < N; i++)
            {
                items.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < N - 1; i++)
            {
                var ret = items[i + 1] - items[i];
                if (ret > 0)
                {
                    Console.WriteLine("up " + Math.Abs(ret));
                }
                else if (ret < 0)
                {
                    Console.WriteLine("down " + Math.Abs(ret));

                }
                else
                {
                    Console.WriteLine("stay");

                }
            }
        }
    }
}