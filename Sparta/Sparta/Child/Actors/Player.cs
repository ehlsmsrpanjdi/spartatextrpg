using Sparta.Child.Actors.ItemSystem;
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

        }
    }

    
}
