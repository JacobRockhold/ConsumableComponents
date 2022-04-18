using ConsumableComponents.Consumables;

namespace ConsumableComponents
{
    internal class Game
    {
        public IPlayer Player { get; set; }
        public ConsumableInventory Consumables { get; set; }

        public Game()
        {
            Player = new Player();
            Consumables = new ConsumableInventory();
            Run();
        }

        private void Run()
        {
            while (true)
            {
                //if (!ContinuePlay())
                //{
                //    break;
                //}
                var order = OrderConsumbale();
                Console.WriteLine();
                Console.WriteLine("\r\nBefore:");
                Player.DisplayStats();
                Player.Consume((IConsumable)order);
                Console.WriteLine("\r\nAfter:");
                Player.DisplayStats();
                Console.WriteLine();
            }
        }

        private object OrderConsumbale()
        {
            object item = new object();
            var ordered = false;
            while (ordered == false)
            {
                Console.WriteLine("Please enter a consumable from the list:");
                Consumables.DisplayConsumables();
                Console.WriteLine("\r");
                var order = Console.ReadLine();
                if (order == null)
                {
                    Console.WriteLine("Try again");
                    continue;
                }
                item = Consumables.Order(order);
                ordered = true;
            }
            return item;
        }

        public bool ContinuePlay()
        {
            var play = true;
            while (play)
            {
                Console.WriteLine("Play? [y] or [n]");
                var words = Console.ReadLine();
                Console.WriteLine("\r");

                if (words == null)
                {
                    Console.WriteLine("Try again.");
                    continue;
                }
                if (words.StartsWith("n"))
                {
                    break;
                }
                return true;
            }
            return false;

        }
    }
}
