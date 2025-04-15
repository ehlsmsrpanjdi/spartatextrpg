using Sparta.Child;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta.Parent
{
    class Field
    {
        public string Name { get; set; } = "";

        public Field()
        {

        }
        public Field(string name)
        {
            Name = name;
        }

        public virtual void Tick()
        {
        }

        public void SpawnActor<ChildActor>() where ChildActor : Actor , new()
        {
            ChildActor actor = new ChildActor();
            actor.BeginPlay();
            Actors.Add(actor);
        }

        public virtual void BeginPlay()
        {

        }

        public virtual void EndPlay()
        {
            Actors.Clear();
        }

        public void ChangeField(string _fieldName)
        {
            TextRpg.GetInst().FieldChange(_fieldName);
        }

        List<Actor> Actors = new List<Actor>();
        protected Selector selector = new Selector();
        protected int selectedIndex = 0;
    }
}
