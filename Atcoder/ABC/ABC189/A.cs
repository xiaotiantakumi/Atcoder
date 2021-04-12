using System;

namespace Atcoder.ABC.ABC189
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var input = Console.ReadLine();
            for (var i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    Console.WriteLine("Lost");
                    return;
                }
            }

            Console.WriteLine("Won");
        }
    }
}