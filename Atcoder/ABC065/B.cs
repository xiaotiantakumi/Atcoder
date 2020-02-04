using System;
using System.Collections.Generic;

namespace Atcoder.ABC065
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            Dictionary<int, int> input = new Dictionary<int, int>();
            for (int i = 0; i < N; i++)
            {
                input.Add(i + 1, int.Parse(Console.ReadLine()));
            }

            int buttonPos = 1;
            for (int i = 0; i < N; i++)
            {
                buttonPos = input[buttonPos];
                if (buttonPos == 2)
                {
                    Console.WriteLine(i + 1);
                    return;
                }
            }
            Console.WriteLine("-1");
        }
    }
}