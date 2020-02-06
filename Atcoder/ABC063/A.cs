using System;
using System.Linq;

namespace Atcoder.ABC063
{
    public class A : AtcoderBase
    {
        public void Run()
        {
            var r = ReadIntArray().Sum();
            Console.WriteLine(r < 10 ? r.ToString() : "error");
        }
    }
}