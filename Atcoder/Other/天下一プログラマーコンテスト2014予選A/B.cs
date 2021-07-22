using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.Other.天下一プログラマーコンテスト2014予選A
{
    public class B : CoderBase
    {
        public override void Run()
        {
        }

        class MyClass
        {
            private long _combo = 0;
            private readonly int NOMAL_ATTACK = 10;
            private readonly int TAME_ATTACK = 50;
            private long _fukuro = 5;
            private int _waitSec = 0;
            private decimal totalDamage = 0;
            private int costNomal = 6;
            private int costTame = 8;
            Stack<decimal> damageStack = new Stack<decimal>();
            public MyClass()
            {
            }

            public void NomalAttack()
            {
                if (damageStack.Any()) totalDamage += damageStack.Pop();
                if (_waitSec > 0) --_waitSec;
                if (_fukuro > 0 && _waitSec == 0)
                {
                    var ratio = Math.Floor((decimal)_combo / 10);
                    damageStack.Push(NOMAL_ATTACK * (1 + ratio * 0.1m));
                    _combo++;
                    _waitSec += 6;
                    _fukuro--;
                }
            }

            public void TameAttack()
            {
                if (damageStack.Any()) totalDamage += damageStack.Pop();
                if (_waitSec > 0) --_waitSec;
                if (_fukuro > 0 && _waitSec == 0)
                {
                    var ratio = Math.Floor((decimal)_combo / 10);
                    damageStack.Push(TAME_ATTACK * (1 + ratio * 0.1m));
                    _combo++;
                    _waitSec += 6;
                    _fukuro -= 3;
                }
            }

            public void GainFukuro()
            {
                //waitNomal.f
            }
        }
    }
}