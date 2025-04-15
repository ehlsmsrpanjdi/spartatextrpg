﻿using Sparta.Child.Fields;
using Sparta.NameSpace;
using Sparta.Parent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta.Child
{
    class TextRpg : MainGame
    {
        private static TextRpg Instance = null;
        public static TextRpg GetInst()
        {
            if (Instance == null)
            {
                Instance = new TextRpg();
            }
            return Instance;
        }


        public override void Start()
        {
            bool selectedcomplete = false;
            while (!selectedcomplete)
            {
                Console.Clear();
                Console.WriteLine("0. 게임 시작하기");
                Console.WriteLine("1. 게임 불러오기");

                selectedIndex = selector.Select();

                switch (selectedIndex)
                {
                    case 0:
                        break;
                    case 1:
                        CreateField<MainField>(FieldName.MainField);

                        FieldChange(FieldName.MainField);
                        base.Start();
                        selectedcomplete = true;
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        Key.AnyKey();
                        break;
                }
            }
        }

    }


}

