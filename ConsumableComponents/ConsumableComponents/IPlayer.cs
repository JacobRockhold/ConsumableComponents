using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumableComponents
{
    public interface IPlayer
    {
        public void Consume(IConsumable consumable);
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Magic { get; set; }
    }
}
