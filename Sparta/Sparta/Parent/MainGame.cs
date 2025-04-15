using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta.Parent
{
    class MainGame
    {
        protected MainGame()
        {

        }


        public void CreateField<ChildField>(string name) where ChildField : Field, new()
        {
            name = name.ToUpper();
            ChildField field = new ChildField();
            field.Name = name;
            fieldDictionary.Add(name, field);
        }

        public void FieldChange(string name)
        {
            name = name.ToUpper();
            if (selectedField != null)
            {
                if (fieldDictionary.TryGetValue(name, out Field field))
                {
                    Field PrevField = selectedField;
                    Field CurrentField = field;

                    PrevField.EndPlay();

                    CurrentField.BeginPlay();
                    selectedField = CurrentField;
                    return;
                }
            }
            else
            {
                if (fieldDictionary.TryGetValue(name, out Field field))
                {
                    selectedField = field;
                    selectedField.BeginPlay();
                    return;
                }
            }
        }

        virtual public void Start()
        {
            while (!IsEnd)
            {
                Tick();
            }
        }

        public void Tick()
        {
            if(selectedField != null)
            {
                selectedField.Tick();
            }
        }

        public void GameEnd()
        {
            IsEnd = true;
        }

        Field selectedField = null;
        private bool IsEnd = false;

        Dictionary<string, Field> fieldDictionary = new Dictionary<string, Field>();
    }
}
