using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC010
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var As = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ret = 0;
            for (int i = 0; i < N; i++)
            {
                var tar = As[i];
                while (true)
                {
                    if (tar % 2 != 0 && tar % 3 != 2)
                    {
                        break;
                    }
                    ret++;
                    tar--;
                }
            }

            Console.WriteLine(ret);
        }
    }
}