using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC098
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            string X = string.Empty;
            string Y = string.Empty;
            int ret = 0;
            for (int i = 0; i < N; i++)
            {
                int tmpRet = 0;
                X += S[i];
                Y = string.Empty;
                for (int j = i + 1; j < N; j++)
                {
                    Y += S[j];
                }

                var XList = X.Distinct().ToList();
                foreach (var x in XList)
                {
                    var tmp = Y.IndexOf(x);
                    if (tmp != -1)
                    {
                        tmpRet++;
                    }
                }

                if (ret < tmpRet)
                {
                    ret = tmpRet;
                }
            }
            Console.WriteLine(ret);
        }
    }
}