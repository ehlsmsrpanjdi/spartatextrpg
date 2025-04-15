﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta
{
    class Selector
    {
        public Selector() { }
        public int Select()
        {
            Console.Write("선택지를 고르시오 : ");
             string input = Console.ReadLine();
            Console.Clear();
            if(int.TryParse(input, out int value))
            {
                return value;
            }
            return 0;
        }
    }
}
