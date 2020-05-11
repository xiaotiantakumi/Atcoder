using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC.ABC026
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            bool isPlus = false;
            if (N % 2 != 0)
            {
                isPlus = true;
            }
            double ret = 0;
            List<int> rList = new List<int>();
            for (int i = 0; i < N; i++)
            {
                rList.Add(int.Parse(Console.ReadLine()));
            }
            foreach (var r in rList.OrderBy(x => x))
            {
                if (isPlus)
                {
                    ret += Math.Pow(r, 2);
                }
                else
                {
                    ret -= Math.Pow(r, 2);
                }

                isPlus = !isPlus;
            }

            Console.WriteLine(ret * Math.PI);
        }
    }
}