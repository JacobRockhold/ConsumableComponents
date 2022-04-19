﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumableComponents.Consumables
{
    public class Apple : IConsumable
    {
        public string Name { get; set; } = "Apple";
        public int HealthGained { get; set; } = 2;
        public int StrengthGained { get; set; } = 0;
        public int MagicGained { get; set; } = 0;
    }
}
