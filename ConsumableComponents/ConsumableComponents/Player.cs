namespace ConsumableComponents
{
    public class Player : IPlayer
    {
        public Stats Stats { get; set; }

        public Player()
        {
            Stats = new Stats();
            Stats.UpdateStats(10, 10, 10);
        }

        public void DisplayStats()
        {
            Console.WriteLine($"Health: {Stats.GetHealthValue()}");
            Console.WriteLine($"Strength: {Stats.GetStrengthValue()}");
            Console.WriteLine($"Magic: {Stats.GetMagicValue()}");
        }
    }
}
