using System;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Hangman
{
    internal class Program
    {
        static private string[] hangmanKeys = new string[] { "DEVELOPER", "MICROSOFT", "SKILLS", "JOURNEY" };
        private const int maxAttemptsCounter = 11;
        static private int remainingAttemptsCounter;
        static private char[] word2GuessArray = [];
        static private char[] hiddenWord2GuessArray = [];
        static private string? hiddenWord2Guess;
        static private string? word2Guess;
        static private bool gameWon;
        static private bool gameLost;
        static private bool gameOn = true;

        static void Main(string[] args)
        {
            while (gameOn)
            {
                StartNewGame();
                ChooseWord2Play();
                GameLogic();
                EndGameMessage();
            }
        }


        static private void StartNewGame()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the hangman game!");
            Random random = new Random();
            int randomWordIndex = random.Next(0, hangmanKeys.Length);
            word2Guess = hangmanKeys[randomWordIndex];
            word2GuessArray = word2Guess.ToCharArray();
            
            hiddenWord2Guess = word2Guess;
            for (int i = 0; i < word2Guess.Length; i++)
            {
                char char2Replace = word2Guess[i];
                hiddenWord2Guess = hiddenWord2Guess.Replace(char2Replace, '_');
            }
            // Game state initiation
            hiddenWord2GuessArray = hiddenWord2Guess.ToCharArray();

            // Remaining attempts initation
            remainingAttemptsCounter = maxAttemptsCounter;
            
        }
        static private void ChooseWord2Play()
        {
            foreach (string key in hangmanKeys)
            {
                string modifiedKey = key;
                for (int i = 0; i < key.Length; i++)
                {
                    char char2Replace = key[i];
                    modifiedKey = modifiedKey.Replace(char2Replace, '_');
                }
            }
            remainingAttemptsCounter = maxAttemptsCounter;
        }
        static private void CheckLetter()
        {
            {
                bool letterFound = false;
                Console.Write("Guess a letter: ");
                string? inputString = Console.ReadLine();

                while (string.IsNullOrEmpty(inputString) || !Char.IsLetter(inputString[0]) || inputString.Length > 1)
                {
                    Console.Clear();
                    Console.Write("That's not a letter. Type a letter!: ");
                    inputString = Console.ReadLine();
                }

                char inputChar = inputString[0];
                inputChar = Char.ToUpper(inputChar);

                for (int i = 0; i < word2GuessArray.Length; i++)
                {
                    if (word2GuessArray[i] == inputChar)
                    {
                        hiddenWord2GuessArray[i] = inputChar;
                        letterFound = true;
                    }
                    else
                    {
                        Console.WriteLine(remainingAttemptsCounter);
                    }
                }
                if (!letterFound)
                {
                    remainingAttemptsCounter--;
                }
                hiddenWord2Guess = string.Join("", hiddenWord2GuessArray);
                Console.WriteLine(hiddenWord2GuessArray);
                Console.WriteLine(word2GuessArray);
                Console.WriteLine(remainingAttemptsCounter);
                Console.Clear();
            }
        }
        static private void UpdateUI()
        {
            Console.WriteLine(hiddenWord2GuessArray);
            Console.WriteLine();
            Console.WriteLine($"You still have {remainingAttemptsCounter} attempts left.");
            switch (remainingAttemptsCounter)
            {
                case 11:
                    Console.WriteLine("###########");
                    break;
                case 10:
                    Console.WriteLine("  ##");
                    Console.WriteLine("  ##");
                    Console.WriteLine("  ##");
                    Console.WriteLine("  ##");
                    Console.WriteLine("  ##");
                    Console.WriteLine("  ##");
                    Console.WriteLine("  ##");
                    Console.WriteLine("###########");
                    
                    break;
                case 9:
                    Console.WriteLine("  #######");
                    Console.WriteLine("  ##");
                    Console.WriteLine("  ##");
                    Console.WriteLine("  ##");
                    Console.WriteLine("  ##");
                    Console.WriteLine("  ##");
                    Console.WriteLine("  ##");
                    Console.WriteLine("  ##");
                    Console.WriteLine("###########");
                    break;
                case 8:
                    Console.WriteLine("  ########");
                    Console.WriteLine("  ##   |  ");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("############");
                    break;
                case 7:
                    Console.WriteLine("  ########");
                    Console.WriteLine("  ##   |  ");
                    Console.WriteLine("  ##   |  ");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("############");
                    break;
                case 6:
                    Console.WriteLine("  ########");
                    Console.WriteLine("  ##   | ");
                    Console.WriteLine("  ##   | ");
                    Console.WriteLine("  ##   @ ");
                    Console.WriteLine("  ##     ");
                    Console.WriteLine("  ##     ");
                    Console.WriteLine("  ##     ");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("############");
                    break;
                case 5:
                    Console.WriteLine("  ########");
                    Console.WriteLine("  ##   |  ");
                    Console.WriteLine("  ##   |  ");
                    Console.WriteLine("  ##   @  ");
                    Console.WriteLine("  ##   |  ");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("############");
                    break;
                case 4:
                    Console.WriteLine("  ########");
                    Console.WriteLine("  ##   | ");
                    Console.WriteLine("  ##   | ");
                    Console.WriteLine("  ##   @ ");
                    Console.WriteLine("  ##  -|- ");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("############");
                    break;
                case 3:
                    Console.WriteLine("  ########");
                    Console.WriteLine("  ##   |  ");
                    Console.WriteLine("  ##   |  ");
                    Console.WriteLine("  ##   @  ");
                    Console.WriteLine("  ## .-|-.");
                    Console.WriteLine("  ## '   '");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("############");
                    break;
                case 2:
                    Console.WriteLine("  ########");
                    Console.WriteLine("  ##   |  ");
                    Console.WriteLine("  ##   |  ");
                    Console.WriteLine("  ##   @  ");
                    Console.WriteLine("  ## .-|-.");
                    Console.WriteLine("  ## ' | '");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("############");
                    break;
                case 1:
                    Console.WriteLine("  ########");
                    Console.WriteLine("  ##   |  ");
                    Console.WriteLine("  ##   |  ");
                    Console.WriteLine("  ##   @  ");
                    Console.WriteLine("  ## .-|-.");
                    Console.WriteLine("  ## ' | '");
                    Console.WriteLine("  ## _|   ");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("############");
                    break;
                case 0:
                    Console.WriteLine("  ########");
                    Console.WriteLine("  ##   |  ");
                    Console.WriteLine("  ##   |  ");
                    Console.WriteLine("  ##   @  ");
                    Console.WriteLine("  ## .-|-.");
                    Console.WriteLine("  ## ' | '");
                    Console.WriteLine("  ## _| |_");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("############");
                    Console.WriteLine("Game over");
                    break;
            }
        } 
        static private bool IsWordGuessed(string word2Guess)
        {
            return (!word2Guess.Contains("_"));
        }
        static private bool IsGameLost(int remainingAttemptsCounter)
        {
            return (!(remainingAttemptsCounter != 0));
        }
        static private void EndGameMessage()
        {
            if (gameWon)
            {
                gameWon = false;
                Console.Clear();
                for (int i = 0; i < 50; i++)
                {
                    Console.Write("*");
                    Thread.Sleep(10);
                }
                Console.WriteLine();
                Console.WriteLine($"You are the winner. the search word was: {hiddenWord2Guess}.");
                for (int i = 0; i < 50; i++)
                {
                    Console.Write("*");
                    Thread.Sleep(10);
                }
                Console.WriteLine();
                Console.WriteLine("To quit type: N and press enter. ");
                Console.Write("To play again type: anything and press enter. ");
                string? decision = Console.ReadLine();
                while (string.IsNullOrEmpty(decision))
                {
                    Console.WriteLine("To quit type: N and press enter");
                    Console.Write("To play again type: anything and press enter. ");
                    decision = Console.ReadLine();
                }
                char decisionChar = Char.ToUpper(decision[0]);

                if (decisionChar == 'N')
                {
                    gameOn = false;
                    Console.WriteLine();
                    Console.WriteLine("Goodbye!");
                }
            }

            if (gameLost)
            {
                Console.Clear();
                gameLost = false;
                for (int i = 0; i < 50; i++)
                {
                    Console.Write("*");
                    Thread.Sleep(10);
                }
                Console.WriteLine();
                Console.WriteLine($"You lost. the search word was: developer: {word2Guess}.");
                for (int i = 0; i < 50; i++)
                {
                    Console.Write("*");
                    Thread.Sleep(10);
                }
                Console.WriteLine();
                Console.WriteLine("To quit type: N and press enter. ");
                Console.Write("To play again type: anything and press enter. ");
                string? decision = Console.ReadLine();
                while (string.IsNullOrEmpty(decision))
                {
                    Console.WriteLine("To quit type: N and press enter. ");
                    Console.Write("To play again type: anything and press enter. ");
                    decision = Console.ReadLine();
                }
                char decisionChar = Char.ToUpper(decision[0]);

                if (decisionChar == 'N')
                {
                    gameOn = false;
                    Console.WriteLine();
                    Console.WriteLine("Goodbye!");
                }
            }

            
        }
        static private void GameLogic()
        {
            while (!gameLost && !gameWon)
            {
                CheckLetter();
                UpdateUI();
                gameWon = hiddenWord2Guess != null && IsWordGuessed(hiddenWord2Guess);
                gameLost = IsGameLost(remainingAttemptsCounter);
            }
        }
    }
}