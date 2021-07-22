using System;
using System.Text;
using CoderCommon;

namespace Atcoder.ABC.ABC033
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var S = Console.ReadLine();
            StringBuilder part = new StringBuilder();
            int ret = 0;
            bool hasZero = false;
            for (int i = 0; i < S.Length; i++)
            {
                part.Append(S[i]);
                if (S[i] == '0') hasZero = true;
                if (S[i] == '+' || i == S.Length - 1)
                {
                    ret += hasZero ? 0 : 1;
                    part.Clear();
                    hasZero = false;
                }
            }

            Console.WriteLine(ret);
        }
    }
}