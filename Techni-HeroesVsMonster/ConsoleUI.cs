namespace Techni_HeroesVsMonster
{
    public class ConsoleUI
    {
        public List<ConsoleKey> ValidKeys = new List<ConsoleKey> {ConsoleKey.DownArrow, ConsoleKey.UpArrow, ConsoleKey.LeftArrow, ConsoleKey.RightArrow, ConsoleKey.P};
        public ConsoleKey UserInput()
        {
            ConsoleKeyInfo userInput  = Console.ReadKey();
            do
            {
                userInput = Console.ReadKey();
            } while (ValidKeys.Exists(x => x == userInput.Key));
            return userInput.Key;
        
        }
        public void HandleInput(ConsoleKey userInput)
        {
            bool validInput = false;
            switch (userInput)
            {
                case ConsoleKey.DownArrow:
                    validInput = MoveDown();
                break;
                case ConsoleKey.UpArrow:
                    validInput = MoveUp();
                    break;
                case ConsoleKey.RightArrow:
                    validInput = MoveRight();
                    break;
                case ConsoleKey.LeftArrow:
                    validInput = MoveLeft();
                    break;
            }
        }

        private bool MoveLeft()
        {
            throw new NotImplementedException();
        }

        private bool MoveUp()
        {
            throw new NotImplementedException();
        }

        private bool MoveRight()
        {
            throw new NotImplementedException();
        }

        private bool MoveDown()
        {
            throw new NotImplementedException();
        }
    }
}