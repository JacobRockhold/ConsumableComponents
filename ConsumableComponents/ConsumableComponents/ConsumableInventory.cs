using ConsumableComponents.Consumables;

namespace ConsumableComponents
{
    internal class ConsumableInventory : List<IConsumable>
    {
        public void DisplayConsumables()
        {
            Console.WriteLine("1. Apple");
            Console.WriteLine("2. Apple Pie");
            Console.WriteLine("3. Strength Potion");

            Console.WriteLine("Enter the number not the name.");
        }

        internal object? Order(string order)
        {
            if (string.IsNullOrEmpty(order)) throw new NullReferenceException();
            switch (order.ToLower())
            {
                case "1":
                    return new Apple();
                case "2":
                    return new ApplePie();
                case "3":
                    return new StrengthPotion();
                default:
                    return null;
            }
        }
    }
}
