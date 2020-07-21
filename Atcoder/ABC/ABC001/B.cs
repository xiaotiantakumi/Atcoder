using System;

namespace Atcoder.ABC001
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var m = int.Parse(Console.ReadLine());
            if (m < 100)
            {
                Console.WriteLine("00");
            }
            else if (100 <= m && m <= 5000)
            {
                var tmp = m * 10 / 1000;
                if (tmp.ToString().Length == 1)
                {
                    Console.WriteLine("0" + tmp.ToString());
                    return;
                }

                Console.WriteLine(tmp.ToString());

            }
            else if (6000 <= m && m <= 30000)
            {
                Console.WriteLine(m / 1000 + 50);
            }
            else if (35000 <= m && m <= 70000)
            {
                Console.WriteLine((m / 1000 - 30) / 5 + 80);
            }
            else if (m > 70000)
            {
                Console.WriteLine(89);
            }
        }
    }
}