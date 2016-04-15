using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    public class Mage : AdvancedCharacter, IAttack
    {
        private const int DefaultAttack = 300;
        private const int DefaultHealth = 150;
        private const int DefaultDefense = 50;
        private const int DefaultRange = 5;
        private int attackPoints;

        public Mage(string id, int x, int y, Team team)
                : base(id, x, y, DefaultHealth, DefaultDefense, team, DefaultRange)
        {
            this.AttackPoints = DefaultAttack;
        }

        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            set
            {
                this.attackPoints = value;
            }
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList
                 .Where(c => c.Id != this.Id)
                 .Where(c => c.Team != this.Team)
                 .Where(c => c.IsAlive)
                 .LastOrDefault();
        }

        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            this.AttackPoints += item.AttackEffect;

        }
        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            this.AttackPoints -= item.AttackEffect;
        }
        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(string.Format("-- {0}, Attack {1}", base.ToString(), this.AttackPoints));
            return output.ToString();
        }
    }
}
