using System;
using System.Text;

namespace Atcoder.ABC.ABC019
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var s = Console.ReadLine();
            char current = s[0];
            int count = 1;
            StringBuilder ret = new StringBuilder();
            for (int i = 1; i < s.Length; i++)
            {
                if (current == s[i])
                {
                    count++;
                }
                else
                {

                    ret.Append(current + count.ToString());
                    current = s[i];
                    count = 1;
                }

                if (i == s.Length - 1)
                {
                    ret.Append(current + count.ToString());
                }
            }

            Console.WriteLine(ret.ToString());
        }
    }
}