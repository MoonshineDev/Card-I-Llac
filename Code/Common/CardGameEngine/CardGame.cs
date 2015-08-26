using System;

namespace CardGameEngine
{
    public class CardGame
    {
        private readonly IConsole _console;

        public CardGame(IConsole console)
        {
            if (console == null) throw new ArgumentNullException("console");
            _console = console;
        }

        public void InitializeDeck()
        {
        }
    }
}