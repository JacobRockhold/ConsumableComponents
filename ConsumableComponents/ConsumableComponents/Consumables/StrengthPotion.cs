namespace ConsumableComponents.Consumables
{
    public class StrengthPotion : IConsumable
    {
        public string Name { get => "Strength Potion"; set => _ = "Strength Potion"; }
        public int HealthGained { get; set; } = 0;
        public int StrengthGained { get; set; } = 50;
        public int MagicGained { get; set; } = 0;
    }
}
