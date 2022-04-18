namespace ConsumableComponents
{
    public interface IPlayer
    {
        public void Consume(IConsumable consumable);
        public void DisplayStats();
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Magic { get; set; }
    }
}
