using Sparta.Parent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta.Child.Fields
{
    class MainField : Field
    {
        public override void Tick()
        {
            base.Tick();
            Console.WriteLine("메인 마을입니다");

            Console.WriteLine("1. 상점");
            Console.WriteLine("2. 여관");
            Console.WriteLine("3. 밖으로");

            selectedIndex = selector.Select();
        }

        public override void BeginPlay()
        {
            base.BeginPlay();
        }

    }
}
