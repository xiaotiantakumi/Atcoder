using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC109
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var A = firstLine[0];
            var B = firstLine[1];
            //ABの積が奇数か偶数かを判断する。偶数に何をかけても偶数
            if ((A * B) % 2 == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}