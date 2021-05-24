using System;

namespace Atcoder.ABC.ABC196
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var s = Console.ReadLine();
            var pos = s.IndexOf(".");
            if (pos == -1)
            {
                Console.WriteLine(s);
                return;
            }

            Console.WriteLine(s.Substring(0, pos));
        }
    }
}