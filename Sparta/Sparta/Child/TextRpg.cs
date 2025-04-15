using Sparta.Child.Fields;
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
            CreateField<MainField>(FieldName.MainField);

            FieldChange(FieldName.MainField);
            base.Start();
        }


    }
}
