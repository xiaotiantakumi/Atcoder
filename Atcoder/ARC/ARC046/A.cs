using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ARC.ARC046
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var N = int.Parse(Console.ReadLine());
            int cnt = 0;
            long current = 1;
            while (cnt < N)
            {
                var first = current.ToString().First();
                bool flg = true;
                foreach (var c in current.ToString())
                {
                    if (c != first)
                    {
                        flg = false;
                        break;
                    }
                }

                if (flg)
                {
                    cnt++;
                }
                current++;
            }

            Console.WriteLine(current - 1);
        }
    }
}