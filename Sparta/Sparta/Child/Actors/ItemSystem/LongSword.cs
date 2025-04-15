using Sparta.NameSpace;
using Sparta.Parent;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sparta.Child.Actors.ItemSystem
{
    public class Inventory
    {
        public Inventory()
        {
            ItemInfo[ItemName.LongSword] = new LongSword();
            ItemInfo[ItemName.LeatherArmour] = new LeatherArmour();
            ItemInfo[ItemName.OrcArmour] = new OrcArmour();
            ItemInfo[ItemName.OrcSword] = new OrcSword();
        }

        public void GainItem(string _itmeName)
        {
            ++Inven[_itmeName];
        }

        public int PopItem(string _itmeName, int _num)
        {
            if(Inven.ContainsKey(_itmeName) == true)
            {
                if(Inven[_itmeName] >= _num)
                {
                    Inven[_itmeName] -= _num;
                    return ItemInfo[_itmeName].price * _num;
                }
                if (Inven[_itmeName] == _num)
                {
                    Inven.Remove(_itmeName);
                    return ItemInfo[_itmeName].price * _num;
                }
            }
            Console.WriteLine("개수가 모자랍니다");
            Key.AnyKey();
            return 0;
        }

        public Item? GetItem(int _index)
        {
            int index = 1;
            foreach (KeyValuePair<string, int> pair in Inven)
            {
                if(_index == index)
                {
                    string key = pair.Key;
                    --Inven[pair.Key];
                    if(Inven[pair.Key] == 0)
                    {
                        Inven.Remove(pair.Key);
                    }
                    return ItemInfo[pair.Key];
                }
                ++index;
            }
            return null;
        }

        public void Print()
        {
            int index = 1;
            foreach(KeyValuePair<string, int> pair in Inven)
            {
                Console.Write("{0} : ", index++);
                Console.WriteLine("{0} X {1}", pair.Key, pair.Value);
            }
        }

        Dictionary<string, int> Inven = new Dictionary<string, int>();

        Dictionary<string, Item> ItemInfo = new Dictionary<string, Item>();
    }


    class LongSword : Item
    {
        public LongSword()
        {
            Type = ItemType.Weapon;
            attack = 10;
            ItemName = "장검";
            price = 100;
        }
    }


    class LeatherArmour : Item
    {
        public LeatherArmour()
        {
            Type = ItemType.Armour;
            shield = 3;
            ItemName = "가죽갑옷";
            price = 100;
        }
    }

    class OrcArmour : Item
    {
        public OrcArmour()
        {
            Type = ItemType.Armour;
            shield = 2;
            ItemName = "오크갑옷";
            price = 50;
        }
    }

    class OrcSword : Item
    {
        public OrcSword()
        {
            Type = ItemType.Armour;
            shield = 5;
            ItemName = "오크장검";
            price = 50;
        }
    }
}