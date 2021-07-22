using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC100
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var As = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ret = 0;
            foreach (var item in As)
            {

                var tmp = item;
                while (true)
                {
                    if (tmp % 2 == 0)
                    {
                        ret++;
                        tmp = tmp / 2;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(ret);
        }
    }
}