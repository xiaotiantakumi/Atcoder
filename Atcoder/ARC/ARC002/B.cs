using System;

namespace Atcoder.ARC.ARC002
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var date = DateTime.Parse(Console.ReadLine());
            while (true)
            {
                var val = (double)date.Year / date.Month / date.Day;
                if (val == (int)val)
                {
                    Console.WriteLine(date.ToString("yyyy/MM/dd"));
                    return;
                }
                date = date.AddDays(1);
            }
        }
    }
}