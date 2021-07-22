using System;
using System.Collections.Generic;
using CoderCommon;

namespace Atcoder.ABC044
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine();
            Dictionary<char, int> word = new Dictionary<char, int>();
            foreach (var c in r)
            {
                if (word.ContainsKey(c))
                {
                    word[c]++;
                }
                else
                {
                    word.Add(c, 1);
                }
            }

            foreach (var pair in word)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}