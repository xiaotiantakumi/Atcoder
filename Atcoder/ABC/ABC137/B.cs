using System;
using System.Linq;

namespace Atcoder.ABC137
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var K = input[0] - 1;
            var X = input[1];
            int from = -1000000;
            int end = 1000000;
            if (X - K > from)
            {
                from = X - K;
            }

            if (X + K < end)
            {
                end = X + K;
            }

            string ret = string.Empty;
            for (int i = from; i <= end; i++)
            {
                ret += i.ToString() + " ";
            }
            Console.WriteLine(ret);
        }
    }
}