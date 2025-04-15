using Sparta.Child.Actors;
using Sparta.NameSpace;
using Sparta.Parent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta.Child.Fields
{
    class ShopField : Field
    {
        public override void Tick()
        {
            base.Tick();
            Console.WriteLine("상점입니다.");

            Console.WriteLine("현재 소지금 : {0}\n\n", Player.GetPlayer().gold);
            

            Console.WriteLine("0. 상태를 살핀다.");
            Console.WriteLine("1. 물건을 구매한다.");
            Console.WriteLine("2. 물건을 판매한다.");
            Console.WriteLine("3. 밖으로");

            selectedIndex = selector.Select();
            switch (selectedIndex)
            {
                case 0:
                    Player.GetPlayer().Tick();
                    break;
                case 1:
                    break;
                case 2:
                    Player.GetPlayer().Sell();
                    break;
                case 3:
                    ChangeField(FieldName.MainField);
                    break;
                default:
                    Key.WrongKey();
                    break;
            }
        }
    }
}
