﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC109
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());

            List<string> spokeList = new List<string>();
            for (int i = 0; i < N; i++)
            {
                var tmpSpoke = Console.ReadLine();
                if (spokeList.Count > 0 && (spokeList.Last().Last() != tmpSpoke.First() || spokeList.Contains(tmpSpoke)))
                {
                    Console.WriteLine("No");
                    return;
                }
                spokeList.Add(tmpSpoke);
            }
            Console.WriteLine("Yes");
        }
    }
}