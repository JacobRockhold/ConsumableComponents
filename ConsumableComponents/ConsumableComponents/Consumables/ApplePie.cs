namespace ConsumableComponents
{
    public class ApplePie : IConsumable
    {
        public string Name { get => "Apple Pie"; set => _ = "Apple Pie"; }

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
            player.Health += 25;
        }

        public void RemoveEffects()
        {
            throw new NotImplementedException();
        }
    }
}