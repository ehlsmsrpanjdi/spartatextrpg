using Sparta.Parent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta.Child.Actors.ItemSystem
{
    class LongSword : Item
    {
        public LongSword()
        {
            Type = ItemType.Weapon;
            attack = 10;
        }
    }

    class LeatherArmour : Item
    {
        public LeatherArmour()
        {
            Type = ItemType.Armour;
            shield = 3;
        }
    }

    class OrcArmour : Item
    {
        public OrcArmour()
        {
            Type = ItemType.Armour;
            shield = 2;
        }
    }

    class OrcSword : Item
    {
        public OrcSword()
        {
            Type = ItemType.Armour;
            shield = 5;
        }
    }
}
