using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABCLike.CADDi_2018_for_Beginners
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var NHW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ret = 0;
            for (int i = 0; i < NHW[0]; i++)
            {
                var AB = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (NHW[1] <= AB[0] && NHW[2] <= AB[1])
                {
                    ret++;
                }
            }

            Console.WriteLine(ret);
        }
    }
}