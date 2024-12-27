using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.wizards_and_warriors
{
    abstract class Character
    {
        private string _characterType;
        protected Character(string characterType) => this._characterType = characterType;
        
        public abstract int DamagePoints(Character target);

        public virtual bool Vulnerable() => false;

        public override string ToString() => $"Character is a {_characterType}";
    }

    class Warrior : Character
    {
        public Warrior() : base("Warrior")
        {
        }

        public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
        
    }

    class Wizard : Character
    {
        private bool _spelled;
        public Wizard() : base("Wizard") => this._spelled = false;

        public override bool Vulnerable() => _spelled ? false : true;

        public override int DamagePoints(Character target) => _spelled ? 12 : 3;

        public void PrepareSpell() => this._spelled = true;
        
    }
}
