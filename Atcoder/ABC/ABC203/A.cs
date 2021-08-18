using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC203
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var abc = Console.ReadLine().Split().Select(long.Parse).ToArray();
            if (abc[0] != abc[1] && abc[0] != abc[2] && abc[1] != abc[2])
            {
                Console.WriteLine(0);
            }
            else
            {
                if (abc[0] == abc[1])
                {
                    Console.WriteLine(abc[2]);
                }
                else if (abc[1] == abc[2])
                {
                    Console.WriteLine(abc[0]);
                }
                else if (abc[0] == abc[2])
                {
                    Console.WriteLine(abc[1]);
                }
            }
        }
    }
}