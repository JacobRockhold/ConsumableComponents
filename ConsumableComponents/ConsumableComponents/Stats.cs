using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumableComponents
{
    public class Stats
    {
        private int Health { get; set; }
        private int Strength { get; set; }
        private int Magic { get; set; }

        /// <summary>
        /// Pass in an integer that should be removed or added.
        /// </summary>
        /// <param name="health"></param>
        /// <param name="strength"></param>
        /// <param name="magic"></param>
        internal void UpdateStats(int health, int strength, int magic)
        {
            Health += health;
            Strength += strength;
            Magic += magic;
            IsMaxed();
        }

        internal void UpdateStats(IConsumable consumable)
        {
            UpdateStats(consumable.HealthGained, consumable.StrengthGained, consumable.MagicGained);
            IsMaxed();
        }

        public void IsMaxed()
        {
            if (Health > MAXHEALTH)
            {
                Health = MAXHEALTH;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine($"Your health is maxed at {MAXHEALTH}.");
                Console.ResetColor();
            }

            if (Strength > MAXSTRENGTH)
            {
                Strength = MAXSTRENGTH;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine($"Your strength is maxed at {MAXSTRENGTH}.");
                Console.ResetColor();
            }

            if (Magic > MAXMAGIC)
            {
                Magic = MAXMAGIC;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine($"Your strength is maxed at {MAXMAGIC}.");
                Console.ResetColor();
            }
        }

        public int GetHealthValue()
        {
            return Health;
        }

        public int GetStrengthValue()
        {
            return Strength;
        }

        public int GetMagicValue()
        {
            return Magic;
        }

        const int MAXHEALTH = 100;
        const int MAXSTRENGTH = 100;
        const int MAXMAGIC = 100;
    }
}
