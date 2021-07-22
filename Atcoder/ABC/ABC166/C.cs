using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC166
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var Hs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool[] batList = new bool[NM[0]];
            for (int i = 0; i < NM[1]; i++)
            {
                var AB = Console.ReadLine().Split().Select(x => int.Parse(x) - 1).ToArray();
                if (Hs[AB[0]] < Hs[AB[1]])
                {
                    batList[AB[0]] = true;
                }
                else if ((Hs[AB[1]] < Hs[AB[0]]))
                {
                    batList[AB[1]] = true;
                }
                else
                {
                    batList[AB[0]] = true;
                    batList[AB[1]] = true;
                }
            }

            Console.WriteLine(batList.Count(x => x == false));
        }
    }
}