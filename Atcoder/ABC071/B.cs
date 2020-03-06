using System;
using System.Linq;

namespace Atcoder.ABC071
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var allStr = "abcdefghijklmnopqrstuvwxyz";
            var r = Console.ReadLine();
            foreach (var c in r)
            {
                var index = allStr.IndexOf(c);
                if (index >= 0)
                {
                    allStr = allStr.Remove(index, 1);
                }
            }
            if (string.IsNullOrEmpty(allStr))
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(allStr.FirstOrDefault());
            }
        }
    }
}