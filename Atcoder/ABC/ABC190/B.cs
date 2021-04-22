using System;
using System.Linq;

namespace Atcoder.ABC.ABC190
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var NSD = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var ret = "No";
            for (int i = 0; i < NSD[0]; i++)
            {
                var XY = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (XY[0] < NSD[1] && XY[1] > NSD[2])
                {
                    ret = "Yes";
                }
            }

            Console.WriteLine(ret);
        }
    }
}