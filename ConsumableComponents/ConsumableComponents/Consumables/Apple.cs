using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumableComponents.Consumables
{
    public class Apple : IConsumable
    {
        public string Name { get => "Apple"; set => _ = "Apple"; }

        public void AddEffects()
        {
            throw new NotImplementedException();
        }

        public void DestroyConsumable()
        {
            throw new NotImplementedException();
        }

        public void Eat(Player player)
        {
            player.Health += 1;
        }

        public void RemoveEffects()
        {
            throw new NotImplementedException();
        }
    }
}
