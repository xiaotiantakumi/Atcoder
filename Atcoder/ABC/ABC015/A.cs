using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC015
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            List<string> lst = new List<string>();
            lst.Add(Console.ReadLine());
            lst.Add(Console.ReadLine());
            Console.WriteLine(lst.OrderByDescending(x => x.Length).First());
        }
    }
}