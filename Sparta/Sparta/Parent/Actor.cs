using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Sparta.Parent
{
    class Actor
    {
        public Actor() { }

        virtual public void BeginPlay()
        {

        }

        public int attack {  get; private set; }
        public int shield { get; private set; }
        public int hp { get; private set; }
        public int gold { get; private set; }

    }
}
