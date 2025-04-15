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

        virtual public void BeginPlay()
        {

        }

        public virtual void Tick()
        {

        }

        public void PrintStatus()
        {
            Console.WriteLine("현재 공격력: {0}", attack);
            Console.WriteLine("현재 방어력: {0}", shield);
            Console.WriteLine("현재 체력: {0}", hp);
            Console.WriteLine("소지 금액 : {0}\n\n\n\n\n\n\n", gold);

            Key.AnyKey();
        }

        public int attack {  get; private set; }
        public int shield { get; private set; }
        public int hp { get; private set; }
        public int gold { get; private set; }

        protected Selector selector = new Selector();
        protected int selectedIndex = 0;
    }
}
