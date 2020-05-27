using System;

namespace Atcoder.PAST._1
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var r = Console.ReadLine();
            int ret = 0;
            if (int.TryParse(r, out ret))
            {
                Console.WriteLine(ret * 2);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}