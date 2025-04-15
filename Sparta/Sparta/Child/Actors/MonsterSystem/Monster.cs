﻿using Sparta.NameSpace;
using Sparta.Parent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sparta.Child.Actors.ItemSystem;

namespace Sparta.Child.Actors.MonsterSystem
{
    class Gobline : Actor
    {
        public Gobline()
        {
            attack = 5;
            shield = 0;
            hp = 60;
            gold = Global.rand.Next(0, 100);
        }
    }

    class Orc : Actor
    {
        public Orc() {
            attack = 5;
            shield = 5;
            hp = 120;
            gold = Global.rand.Next(0, 100);
        }
    }

    class TwinHeadOrc : Actor
    {
        public TwinHeadOrc()
        {
            attack = 10;
            shield = 5;
            hp = 150;
            gold = Global.rand.Next(0, 100);

            int probability = Global.rand.Next(0, 100);
            if (probability > 30){
                TakeOnItem(new OrcArmour());
            }
            if(probability > 60)
            {
                TakeOnItem(new OrcSword());
            }
        }
    }

    class Ogre : Actor
    {
        public Ogre()
        {
            attack = 50;
            shield = 20;
            hp = 120;
            gold = Global.rand.Next(0, 100);
        }
    }
}
