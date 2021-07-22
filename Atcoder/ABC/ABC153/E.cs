using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC153
{
    public class E : CoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var H = r[0];
            var N = r[1];
            List<List<float>> magicList = new List<List<float>>();
            for (int i = 0; i < N; i++)
            {
                var magicInfo = Console.ReadLine().Split().Select(float.Parse).ToList();
                magicInfo.Add(magicInfo[0] / magicInfo[1]);
                magicList.Add(magicInfo);
            }

            long ret = 0;
            var mostEffective = magicList.OrderByDescending(x => x[2]).First();
            int mostEffectiveAttack = int.Parse(mostEffective[0].ToString());
            int mPoint = int.Parse(mostEffective[1].ToString());
            while (H > mostEffectiveAttack)
            {
                H -= mostEffectiveAttack;
                ret += mPoint;
            }
            var lastAttack = magicList.Where(x => x[0] <= H).OrderBy(x => x[1]).First();
            ret += int.Parse(lastAttack[1].ToString());
            Console.WriteLine(ret);
        }
    }
}