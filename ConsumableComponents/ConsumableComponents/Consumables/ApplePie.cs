namespace ConsumableComponents.Consumables
{
    public class ApplePie : IConsumable
    {
        public string Name { get => "Apple Pie"; set => _ = "Apple Pie"; }
        public int HealthGained { get; set; } = 10;
        public int StrengthGained { get; set; } = 0;
        public int MagicGained { get; set; } = 0;
    }
}
