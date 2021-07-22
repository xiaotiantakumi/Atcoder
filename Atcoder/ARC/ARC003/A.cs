using System;
using CoderCommon;

namespace Atcoder.ARC.ARC003
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var r = Console.ReadLine();
            double ret = 0;
            for (int i = 0; i < N; i++)
            {
                switch (r[i])
                {
                    case 'A':
                        ret += 4;
                        break;
                    case 'B':
                        ret += 3;
                        break;
                    case 'C':
                        ret += 2;
                        break;
                    case 'D':
                        ret += 1;
                        break;
                }
            }

            ret /= r.Length;
            Console.WriteLine(ret);
        }
    }
}