using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumableComponents
{
    public interface IConsumable
    {
        public void Eat();
        public void AddEffects();
        public void RemoveEffects();
        public void DestroyConsumable();
    }
}
