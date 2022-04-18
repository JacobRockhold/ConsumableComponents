namespace ConsumableComponents
{
    public interface IConsumable
    {
        public string Name { get; set; }
        public void Eat(Player player);
        public void AddEffects();
        public void RemoveEffects();
        public void DestroyConsumable();
    }
}
