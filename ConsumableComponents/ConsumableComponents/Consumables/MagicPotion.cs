using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumableComponents.Consumables
{
    public class MagicPotion : IConsumable
    {
        public string Name { get; set; } = "Magic Potion";
        public int HealthGained { get; set; } = -1;
        public int StrengthGained { get; set; } = 0;
        public int MagicGained { get; set; } = 50;
    }
}
