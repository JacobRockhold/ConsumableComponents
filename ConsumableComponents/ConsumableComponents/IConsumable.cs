namespace ConsumableComponents
{
    public interface IConsumable
    {
        public string Name { get; set; }
        public int HealthGained { get; set; }
        public int StrengthGained { get; set; }
        public int MagicGained { get; set; }
    }
}
