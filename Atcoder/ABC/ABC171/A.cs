using System;
using System.Text.RegularExpressions;
using CoderCommon;

namespace Atcoder.ABC.ABC171
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var r = Console.ReadLine();
            if (Regex.IsMatch(r, @"[a-z]"))
            {
                Console.WriteLine("a");
            }
            else
            {
                Console.WriteLine("A");
            }
        }
    }
}