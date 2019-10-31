using System;
using System.Linq;

namespace Atcoder.ABC142
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var hArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int ret = 0;
            for (int i = 0; i < firstLine[0]; i++)
            {
                if (hArray[i] >= firstLine[1])
                {
                    ret++;
                }
            }
            Console.WriteLine(ret);
        }
    }
}