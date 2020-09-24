using System;

namespace Atcoder.ARC.ARC002
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var S = Console.ReadLine().ToUpper();
            var ict = "ICT";
            int i = 0;
            foreach (var s in S)
            {
                if (s == ict[i])
                {
                    i++;
                }

                if (i == 3)
                {
                    Console.WriteLine("YES");
                    return;
                }
            }

            Console.WriteLine("NO");
        }
    }
}