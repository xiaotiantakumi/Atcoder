using System;
using System.Linq;

namespace Atcoder.ABC141
{
    public class B : IAtcoder
    {
        public void Run()
        {
            string S = Console.ReadLine();
            char odd = 'R';
            char even = 'L';
            bool ret = true;
            for (int i = 1; i <= S.Length; i++)
            {
                if ((i % 2 == 0 && S[i - 1] == odd) || (i % 2 == 1 && S[i - 1] == even))
                {
                    ret = false;
                    break;
                }
            }

            if (ret)
            {
                Console.Write("Yes");
            }
            else
            {
                Console.Write("No");
            }
        }
    }
}