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
            ItemName = "장검";
        }
        public override void Tick()
        {
        }
    }
}

class LeatherArmour : Item
{
    public LeatherArmour()
    {
        Type = ItemType.Armour;
        shield = 3;
        ItemName = "가죽갑옷";
    }
}

class OrcArmour : Item
{
    public OrcArmour()
    {
        Type = ItemType.Armour;
        shield = 2;
        ItemName = "오크갑옷";
    }
}

class OrcSword : Item
{
    public OrcSword()
    {
        Type = ItemType.Armour;
        shield = 5;
        ItemName = "오크장검";
    }
}
}
