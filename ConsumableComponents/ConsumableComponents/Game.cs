using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumableComponents
{
    internal class Game
    {
        public Game()
        {
            Run();
        }

        private void Run()
        {
            var play = true;
            do
            {

                play = ContinuePlay();
            } while (play);
        }

        public bool ContinuePlay()
        {
            Console.WriteLine("Play? [y] or [n]");
            var words = Console.ReadLine();

            if (words != null && words.StartsWith('n'))
            {
                return false;
            }
            return true;
        }
    }
}
