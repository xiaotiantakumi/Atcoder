using System;
using System.Linq;

namespace Atcoder.TypicalAlgorithm
{
    //ABC130のDより
    public class Syakutori : IAtcoder
    {
        public void Run()
        {
            var first = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var N = (int)first[0];
            var K = first[1];
            var valList = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            long sums = 0;
            long ret = 0;
            int right = 0;
            for (int left = 0; left < N; left++)
            {
                while (right < N && sums < K)
                {
                    sums += valList[right];
                    ++right;
                }

                if (sums < K)
                {
                    break;
                }
                ret += N - right + 1;

                if (left == right)
                {
                    ++right;
                }
                else
                {
                    sums -= valList[left];
                }
            }
            Console.Write(ret);
        }
    }
}