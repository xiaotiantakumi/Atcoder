using System;

namespace Atcoder.ABC.ABC176
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = Console.ReadLine();
            int val = 0;
            foreach (var d in N)
            {
                val += int.Parse(d.ToString());
            }

            if (val % 9 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}