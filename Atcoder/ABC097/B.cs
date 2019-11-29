using System;

namespace Atcoder.ABC097
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var X = int.Parse(Console.ReadLine());

            double ret = 1;
            for (int i = 1; i < X; i++)
            {
                for (int j = 2; j < 1000; j++)
                {
                    var cal = Math.Pow(i, j);
                    if (cal > X)
                    {
                        break;
                    }
                    if (ret < cal)
                    {
                        ret = cal;
                    }
                }
            }
            Console.WriteLine(ret);
        }
    }
}