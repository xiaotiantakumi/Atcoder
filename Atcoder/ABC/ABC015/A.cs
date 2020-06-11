using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC.ABC015
{
    public class A : AtcoderBase
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