namespace ConsumableComponents
{
    public interface IPlayer
    {
        public void DisplayStats();
        public Stats Stats { get; set; }
    }
}
