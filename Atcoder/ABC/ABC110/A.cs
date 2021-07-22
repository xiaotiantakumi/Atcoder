using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC110
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var fLine = Console.ReadLine().Split(' ');
            List<int> tmpList = new List<int>();
            for (int i = 0; i < fLine.Length; i++)
            {
                tmpList.Add(int.Parse(fLine[i]));
            }
            tmpList = tmpList.OrderByDescending(x => x).ToList();

            var left = int.Parse((tmpList[0].ToString() + tmpList[1].ToString()));
            Console.Write(left + tmpList[2]);
        }
    }
}