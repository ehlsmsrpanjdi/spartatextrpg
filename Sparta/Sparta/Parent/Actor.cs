using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Sparta.SelectorSystem;
using Sparta.NameSpace;

namespace Sparta.Parent
{
    class Actor
    {
        public Actor() { }

        public virtual void BeginPlay()
        {

        }

        public virtual void Tick()
        {

        }

        public void PrintStatus()
        {
            int ItemAttack = 0;
            int ItemShield = 0;
            int ItemHp = 0;
            if (Weapon != null)
            {
                ItemAttack += Weapon.attack;
                ItemShield += Weapon.shield;
                ItemHp += Weapon.hp;
            }
            if (Armour != null)
            {
                ItemAttack += Armour.attack;
                ItemShield += Armour.shield;
                ItemHp += Armour.hp;
            }


            Console.WriteLine("레벨 : {0}", Level);
            Console.WriteLine("현재 공격력: {0} + {1}", attack, ItemAttack);
            Console.WriteLine("현재 방어력: {0} + {1}", shield, ItemShield);
            Console.WriteLine("현재 체력: {0}", hp);
            Console.WriteLine("소지 금액 : {0}\n\n\n\n", gold);

            PrintItem();

            Key.AnyKey();
        }

        public virtual void PrintItem()
        {
            if (Weapon != null)
            {
                Weapon.PrintItem();
            }
            else
            {
                Console.WriteLine("무기 없음\n");
            }
            if (Armour != null)
            {
                Armour.PrintItem();
            }
            else
            {
                Console.WriteLine("방어구 없음\n");
            }
            if (Ring1 != null)
            {
                Ring1.PrintItem();
            }
            else
            {
                Console.WriteLine("장신구1 없음\n");
            }
            if (Ring2 != null)
            {
                Ring2.PrintItem();
            }
            else
            {
                Console.WriteLine("장신구2 없음\n");
            }
        }


        public void LevelUp()
        {
            ++Level;
            float attackValue = (float)attack * LevelUpValue;
            float shieldValue = (float)attack * LevelUpValue;
            float hpValue = (float)attack * LevelUpValue;

            attack = (int)attackValue;
            shield = (int)shieldValue;
            hp = (int)hpValue;
        }

        protected void TakeOnItem(Item _item)
        {
            if (_item.equipment == true)
            {
                return;
            }
            if (_item.Type == ItemType.Weapon && Weapon == null)
            {
                Weapon = _item;
                _item.TakeOn();
            }
            else if (_item.Type == ItemType.Armour && Armour == null)
            {
                Armour = _item;
                _item.TakeOn();
            }
            else if (_item.Type == ItemType.Ring && Ring1 == null)
            {
                Ring1 = _item;
                _item.TakeOn();
            }
            else if (_item.Type == ItemType.Ring && Ring2 == null)
            {
                Ring2 = _item;
                _item.TakeOn();
            }
        }

        protected void TakeOffItem()
        {
            while (true)
            {
                Console.WriteLine("0. 나가기");
                Console.WriteLine("1. 무기 해제");
                Console.WriteLine("2. 방어구 해제");
                Console.WriteLine("3. 반지1 해제");
                Console.WriteLine("4. 반지2 해제");
                selectedIndex = selector.Select();
                switch (selectedIndex)
                {
                    case 0:
                        return;
                        break;
                    case 1:
                        if (Weapon != null)
                        {
                            Weapon.TakeOff();
                            Weapon = null;
                        }
                        break;
                    case 2:
                        if (Armour != null)
                        {
                            Armour.TakeOff();
                            Armour = null;
                        }
                        break;
                    case 3:
                        if (Ring1 != null)
                        {
                            Ring1.TakeOff();
                            Ring1 = null;
                        }
                        break;
                    case 4:
                        if (Ring2 != null)
                        {
                            Ring2.TakeOff();
                            Ring2 = null;
                        }
                        break;
                }
            }
        }

        public Item Weapon = null;
        public Item Armour = null;
        public Item Ring1 = null;
        public Item Ring2 = null;


        public int Level { get; protected set; }
        public int attack { get; protected set; }
        public int shield { get; protected set; }
        public int hp { get; protected set; }
        public int gold { get; protected set; }
        public float exp { get; protected set; }

        public float LevelUpValue = 1.1f;

        protected Selector selector = new Selector();
        protected int selectedIndex = 0;
    }
}
