using System;

namespace NumberGuesser
{
    public static class GameEngine
    {
        private static Random _random = new Random();
        private static int _correctNumber = 0;
        private static int _guess = 0;

        public static void isGaming()
        {
            NewGame();
            CheckNumber();
            isWinning();
        }

        private static void NewGame()
        {
            Helpers.PrintColorMessage(ConsoleColor.Yellow, EnumMessages.gameIsStartedMessage);
            Reset();
        }

        private static void CheckNumber()
        {
            Helpers.PrintColorMessage(ConsoleColor.DarkGreen, EnumMessages.readyToChekingMessage);

            while (_guess != _correctNumber)
            {
                string inputNumberString = Console.ReadLine();

                if (!int.TryParse(inputNumberString, out _guess))
                {
                    Helpers.PrintColorMessage(ConsoleColor.Red, EnumMessages.checkActualNumberMessage);
                    continue;
                }

                _guess = Int32.Parse(inputNumberString);

                if (_guess != _correctNumber)
                {
                    Helpers.PrintColorMessage(ConsoleColor.Red, EnumMessages.wrongNumberMessage);
                }
            }
        }

        private static void isWinning()
        {
            Helpers.PrintColorMessage(ConsoleColor.Yellow, EnumMessages.winningMessage);
            Console.WriteLine(EnumMessages.playAgainMessage);
            GetAnswer();
        }

        private static void Reset()
        {
            _correctNumber = _random.Next(1, 10);
            _guess = 0;
        }

        private static void GetAnswer()
        {
            string answerMessage = Console.ReadLine().ToUpper();
            ReadAnswer(answerMessage);
        }
        
        private static void ReadAnswer(string answerMessage)
        {
            if (answerMessage == "Y")
            {
                isGaming();
            }
            else if (answerMessage == "N")
            {
                return;
            }
            else
            {
                Helpers.PrintColorMessage(ConsoleColor.Red, EnumMessages.playAgainMessage);
                GetAnswer();
            }
        }
    }
}
