using System;
using System.Text.RegularExpressions;

namespace Atcoder.ABC.ABC171
{
    public class A : AtcoderBase
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