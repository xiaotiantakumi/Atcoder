using System;
using System.Collections.Generic;

namespace Atcoder.ABC.ABC039
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            List<string> doremi = new List<string>() { "Do", "Do", "Re", "Re", "Mi", "Fa", "Fa", "So", "So", "La", "La", "Si" };
            var mark = "WW";
            var r = Console.ReadLine();
            List<int> postions = new List<int>();
            for (int i = 0; i < r.Length - 1; i++)
            {
                if (r[i] == 'W' && r[i] == r[i + 1])
                {
                    postions.Add(i);
                }
            }

            if (postions[1] - postions[0] >= 7)
            {
                if (postions[0] <= 4)
                {

                }
            }
            else
            {

            }
        }
    }
}