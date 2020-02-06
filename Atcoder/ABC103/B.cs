using System;

namespace Atcoder.ABC103
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var S = Console.ReadLine();
            var T = Console.ReadLine();

            for (int i = T.Length - 1; i >= 0; i--)
            {
                var take = T.Substring(T.Length - 1, 1);
                T = T.Substring(0, T.Length - 1);
                T = T.Insert(0, take);
                if (S == T)
                {
                    Console.WriteLine("Yes");
                    return;
                }
            }
            Console.WriteLine("No");
        }
    }
}