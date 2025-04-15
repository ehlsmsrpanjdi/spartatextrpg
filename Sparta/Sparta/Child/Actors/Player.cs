using Sparta.Child.Actors.ItemSystem;
using Sparta.NameSpace;
using Sparta.Parent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Sparta.Child.Actors
{
    class Player : Actor
    {
        List<Item> items = new List<Item>();

        public void GainItem(Item _item)
        {
            items.Add(_item);
        }

        private static Player? Instance = null;

        public static Player GetPlayer()
        {
            if (Instance == null)
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

            ActType = ActorType.Player;

            TakeOnItem(new LongSword());
            TakeOnItem(new LeatherArmour());
        }

        public override void Tick()
        {
            while (true)
            {
                base.Tick();
                Console.WriteLine("메인 마을입니다");

                Console.WriteLine("0. 가방을 확인한다.");
                Console.WriteLine("1. 장비를 확인한다.");
                Console.WriteLine("2. 나간다.");

                selectedIndex = selector.Select();
                switch (selectedIndex)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Clear();
                        PrintStatus();
                        break;
                    case 2:
                        return;
                    default:
                        Key.WrongKey();
                        break;
                }
            }
        }
    }
}
