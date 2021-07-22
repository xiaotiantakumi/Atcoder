using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC045
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var A = Console.ReadLine();
            var B = Console.ReadLine();
            var C = Console.ReadLine();
            var t = A.First();
            A = A.Substring(1);

            while (true)
            {
                switch (t)
                {
                    case 'a':
                        if (!A.Any())
                        {
                            Console.WriteLine("A");
                            return;
                        }
                        t = A.First();
                        A = A.Substring(1);
                        break;
                    case 'b':
                        if (!B.Any())
                        {
                            Console.WriteLine("B");
                            return;
                        }
                        t = B.First();
                        B = B.Substring(1);
                        break;
                    case 'c':
                        if (!C.Any())
                        {
                            Console.WriteLine("C");
                            return;
                        }
                        t = C.First();
                        C = C.Substring(1);
                        break;
                }
            }
        }
    }
}