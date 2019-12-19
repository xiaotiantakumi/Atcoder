using System;
using System.Linq;

namespace Atcoder.ABC083
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = r[0];
            var A = r[1];
            var B = r[2];
            int ret = 0;
            for (int i = 1; i <= N; i++)
            {
                var tmp = 0;
                var val = i.ToString();
                for (int j = 0; j < val.Length; j++)
                {
                    tmp += int.Parse(val[j].ToString());
                }

                if (tmp >= A && tmp <= B)
                {
                    ret += i;
                }
            }
            Console.WriteLine(ret);
        }
    }
}