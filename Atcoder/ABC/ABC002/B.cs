using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atcoder.ABC.ABC002
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            HashSet<char> except = new HashSet<char>() { 'a', 'i', 'u', 'e', 'o' };
            var W = Console.ReadLine().ToList();
            StringBuilder ret = new StringBuilder();
            foreach (var c in W)
            {
                if (!except.Contains(c)) ret.Append(c);
            }
            Console.WriteLine(ret.ToString());
        }
    }
}