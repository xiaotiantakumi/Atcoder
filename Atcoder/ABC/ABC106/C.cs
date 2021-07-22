using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC106
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var S = Console.ReadLine();
            int K;
            var parseRet = int.TryParse(Console.ReadLine(), out K);
            if (!parseRet)
            {
                K = int.MaxValue;
            }
            string store = string.Empty;
            foreach (var s in S)
            {
                if (string.IsNullOrEmpty(store))
                {
                    store += s.ToString();
                    if (s != '1')
                    {
                        break;
                    }
                }
                else
                {
                    if (s == '1')
                    {
                        store += s.ToString();
                    }
                    else
                    {
                        store += s.ToString();
                        break;
                    }
                }
            }

            if (store.Length < K)
            {
                Console.WriteLine(store.Last());
            }
            else
            {
                Console.WriteLine(store[K - 1]);
            }
        }
    }
}