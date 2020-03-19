using System;

namespace Atcoder.ABC047
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var abc = ReadIntArray();
            if (abc[0] == abc[1] + abc[2] ||
                abc[1] == abc[0] + abc[2] ||
                abc[2] == abc[0] + abc[1])
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}