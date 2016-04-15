using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    public class Healer : AdvancedCharacter, IHeal
    {

        private int healingPoints;
        private const int DefaultHeal = 60;
        private const int DefaultHealth = 75;
        private const int DefaultDefense = 50;
        private const int DefaultRange = 6;

        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, DefaultHealth, DefaultDefense, team, DefaultRange)
        {
            this.HealingPoints = DefaultHeal;
        }

        public int HealingPoints
        {
            get
            {
                return this.healingPoints;
            }

            set
            {
                this.healingPoints = value;
            }
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList
                  .Where(c => c.Id != this.Id)
                  .Where(c => c.Team == this.Team)
                  .Where(c => c.IsAlive)
                  .OrderByDescending(c => c.HealthPoints)
                  .FirstOrDefault();
            //int minHealthPoints = ourTeamTarget.Min(c => c.HealthPoints);
            //return ourTeamTarget.FirstOrDefault(c => c.HealthPoints == minHealthPoints);
        }
        //public override void AddToInventory(Item item)
        //{
        //    this.Inventory.Add(item);
        //    this.ApplyItemEffects(item);
        //}

        //public override void RemoveFromInventory(Item item)
        //{
        //    this.Inventory.Remove(item);
        //    this.RemoveItemEffects(item);
        //}
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(string.Format("-- {0}, Healing {1}", base.ToString(), this.HealingPoints));
            return output.ToString();
        }
    }
}