﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenNos.GameObject.Buff.Indicators.SP3.Swordsman
{
    public class SecondBlessing : IndicatorBase
    {
        public SecondBlessing(int Level)
        {
            Name = "The 2nd Triple Blessing";
            Duration = 150;
            Id = 141;
            _level = Level;
            DirectBuffs.Add(new BCardEntry(BCard.Type.Damage, BCard.SubType.IncreasePercentage, 30, 0, false));
            DirectBuffs.Add(new BCardEntry(BCard.Type.Defense, BCard.SubType.DecreaseCriticalDamage, 20, 0, false));
        }

        public override void Disable(ClientSession session)
        {
            base.Disable(session);
            IndicatorBase buff = new ThirdBlessing(_level);
            session.Character.Buff.Add(buff);
        }
    }
}
