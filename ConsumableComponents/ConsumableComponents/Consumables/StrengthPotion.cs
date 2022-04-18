namespace ConsumableComponents.Consumables
{
    public class StrengthPotion : IConsumable
    {
        public string Name { get => "Strength Potion"; set => _ = "Strength Potion"; }

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
            player.Strength += 50;
        }

        public void RemoveEffects()
        {
            throw new NotImplementedException();
        }
    }
}
