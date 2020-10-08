using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABCLike.Tenka1_Programmer_Beginner_Contest_2018
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var ABK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = ABK[0];
            var B = ABK[1];
            var K = ABK[2];
            bool flg = true;
            while (K != 0)
            {
                if (flg)
                {
                    if (A % 2 == 1)
                    {
                        A--;
                    }

                    var give = A / 2;
                    A -= give;
                    B += give;
                }
                else
                {
                    if (B % 2 == 1)
                    {
                        B--;
                    }

                    var give = B / 2;
                    B -= give;
                    A += give;
                }

                flg = !flg;
                K--;
            }

            Console.WriteLine(A + " " + B);
        }
    }
}