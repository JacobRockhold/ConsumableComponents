namespace ConsumableComponents
{
    internal class ItemConsumer
    {
        public IPlayer Player { get; set; }
        public IConsumable Consumable { get; set; }

        public ItemConsumer(IPlayer player, IConsumable consumable)
        {
            Player = player;
            Consumable = consumable;
            AdjustPlayerStats();
        }

        private void AdjustPlayerStats()
        {
            Console.WriteLine("\r\nBefore:");
            Player.DisplayStats();
            Player.Stats.UpdateStats(Consumable);
            Console.WriteLine("\r\nAfter:");
            Player.DisplayStats();
            Console.WriteLine();
        }

        //private object OrderConsumbale()
        //{
        //    object item = new object();
        //    var ordered = false;
        //    while (ordered == false)
        //    {
        //        Console.WriteLine("Please enter a consumable from the list:");
        //        //Consumable.DisplayConsumables();
        //        Console.WriteLine("\r");
        //        var order = Console.ReadLine();
        //        if (order == null)
        //        {
        //            Console.WriteLine("Try again");
        //            continue;
        //        }
        //        //item = Consumable.Order(order);
        //        ordered = true;
        //    }
        //    return item;
        //}

        //public bool ContinuePlay()
        //{
        //    var play = true;
        //    while (play)
        //    {
        //        Console.WriteLine("Play? [y] or [n]");
        //        var words = Console.ReadLine();
        //        Console.WriteLine("\r");

        //        if (words == null)
        //        {
        //            Console.WriteLine("Try again.");
        //            continue;
        //        }
        //        if (words.StartsWith("n"))
        //        {
        //            break;
        //        }
        //        return true;
        //    }
        //    return false;

        //}
    }
}
