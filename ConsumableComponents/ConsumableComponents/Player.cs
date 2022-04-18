namespace ConsumableComponents
{
    public class Player : IPlayer
    {
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Magic { get; set; }

        const int MAXHEALTH = 100;
        const int MAXSTRENGTH = 100;


        public Player()
        {
            Health = 10;
            Strength = 10;
            Magic = 10;
        }
        public void Consume(IConsumable consumable)
        {
            consumable.Eat(this);
            if (Health > MAXHEALTH)
            {
                Health = MAXHEALTH;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine($"Your health is maxed at {MAXHEALTH}.");
                Console.ResetColor();
            }

            if (Strength > MAXSTRENGTH)
            {
                Strength = MAXSTRENGTH;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine($"Your strength is maxed at {MAXSTRENGTH}.");
                Console.ResetColor();
            }
        }

        public void DisplayStats()
        {
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Magic: {Magic}");
        }
    }
}
