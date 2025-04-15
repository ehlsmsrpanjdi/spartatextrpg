using Sparta.Child.Actors.ItemSystem;
using Sparta.NameSpace;
using Sparta.Parent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta.Child.Actors
{
    class Player : Actor
    {
        private static Player Instance = null;

        public static Player GetPlayer()
        {
            if(Instance == null)
            {
                Instance = new Player();
                Instance.BeginPlay();
            }
            return Instance;
        }

        public override void BeginPlay()
        {
            Level = 1;
            attack = 1;
            shield = 2;
            hp = 100;
            gold = 0;

            TakeOnItem(new LongSword());
            TakeOnItem(new LeatherArmour());
        }

        public override void Tick()
        {
            base.Tick();
            PrintStatus();

            Console.WriteLine("메인 마을입니다");

            Console.WriteLine("0. 장비를 확인한다.");
            Console.WriteLine("1. 나간다.");

            selectedIndex = selector.Select();
            switch (selectedIndex)
            {
                case 0:
                    break;
                case 1:
                    return;
                    break;
                default:
                    Key.WrongKey();
                    break;
            }
        }
    }

    
}
