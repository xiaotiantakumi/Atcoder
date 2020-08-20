using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABCLike
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            string inded = "indeednow";
            inded = new string(inded.OrderBy(x => x).ToArray());
            var N = int.Parse(Console.ReadLine());

            List<string> ret = new List<string>();

            for (int i = 0; i < N; i++)
            {
                var r = new string(Console.ReadLine().OrderBy(x => x).ToArray());
                if (inded == r)
                {
                    ret.Add("YES");
                }
                else
                {
                    ret.Add("NO");
                }
            }

            Console.WriteLine(string.Join("\n", ret));
        }
    }
}