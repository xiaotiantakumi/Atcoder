using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC148
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var A = int.Parse(Console.ReadLine());
            var B = int.Parse(Console.ReadLine());
            var list = new List<int>() { 1, 2, 3 };
            list.Remove(A);
            list.Remove(B);
            Console.WriteLine(list.FirstOrDefault());
        }
    }
}