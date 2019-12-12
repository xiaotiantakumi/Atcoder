using System;

namespace Atcoder.ABC089
{
    public class C : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            int mCount = 0;
            int aCount = 0;
            int rCount = 0;
            int cCount = 0;
            int hCount = 0;
            for (int i = 0; i < N; i++)
            {
                switch (Console.ReadLine()[0])
                {
                    case 'M':
                        mCount++;
                        break;
                    case 'A':
                        aCount++;
                        break;
                    case 'R':
                        rCount++;
                        break;
                    case 'C':
                        cCount++;
                        break;
                    case 'H':
                        hCount++;
                        break;
                }
            }
        }
    }
}