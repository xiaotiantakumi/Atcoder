using System;
using System.Linq;

namespace Atcoder.ABC.ABC161
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var ABC = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(ABC[2] + " " + ABC[0] + " " + ABC[1]);
        }
    }
}