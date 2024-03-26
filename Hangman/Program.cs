using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Hangman
{
    internal class Program
    {
        static private string[] hangmanKeys = new string[] { "DEVELOPER", "MICROSOFT", "SKILLS", "JOURNEY" };
        static private int attemptsCounter = 11;
        static private char[] word2GuessArray = [];
        static private char[] hiddenWord2GuessArray = [];
        static private string? hiddenWord2Guess;

        static void Main(string[] args)
        {

            
            StartNewGame();
            Console.WriteLine("dupa2");
            Console.WriteLine(hiddenWord2Guess);
            Console.WriteLine("dupa2");
            foreach (string key in hangmanKeys)
            {
                Console.WriteLine("key: " + key);
                Console.WriteLine(key + " length: " + key.Length);
                string modifiedKey = key;
                for (int i = 0; i < key.Length; i++)
                {
                    char char2Replace = key[i];
                    modifiedKey = modifiedKey.Replace(char2Replace, '_');
                }
                Console.WriteLine("modifiedKey: " + modifiedKey);
            }
            string input = Console.ReadLine();
            int stage = int.Parse(input);
            Console.WriteLine(stage);



            switch (stage)
            {
                case 0:
                    Console.WriteLine("###########");
                    
                    break;
                case 1:
                    Console.WriteLine("  ##");
                    Console.WriteLine("  ##");
                    Console.WriteLine("  ##");
                    Console.WriteLine("  ##");
                    Console.WriteLine("  ##");
                    Console.WriteLine("  ##");
                    Console.WriteLine("  ##");
                    Console.WriteLine("###########");
                    break;
                case 2:
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
                case 3:
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
                case 4:
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
                case 5:
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
                case 6:
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
                case 7:
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
                case 8:
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
                case 9:
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
                case 10:
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
                case 11:
                    Console.WriteLine("  ########");
                    Console.WriteLine("  ##   |  ");
                    Console.WriteLine("  ##   |  ");
                    Console.WriteLine("  ##   @  ");
                    Console.WriteLine("  ## .-|-.");
                    Console.WriteLine("  ## ' | '");
                    Console.WriteLine("  ## _| |_");
                    Console.WriteLine("  ##      ");
                    Console.WriteLine("############");
                    break;
            }
            string originalName = "Developer";
            char[] originalNameArray = originalName.ToCharArray();
            string modifiedName = "_________";
            char[] modifiedNameArray = modifiedName.ToCharArray();
            while (true) { 
            string inputString = Console.ReadLine();
            char inputChar = inputString[0];

            for (int i = 0; i< originalNameArray.Length; i++)
            {
                if (originalNameArray[i] == inputChar)
                {
                    modifiedNameArray[i] = inputChar;


                }
                else
                {
                    Console.WriteLine("dupa2");
                }

                
            }
            Console.WriteLine(modifiedNameArray);
            }
        }


        static private void StartNewGame()
        {
            Random random = new Random();
            int randomWordIndex = random.Next(0, hangmanKeys.Length);
            string randomWord = hangmanKeys[randomWordIndex];
            word2GuessArray = randomWord.ToCharArray();
            hiddenWord2Guess = randomWord;
            for (int i = 0; i < randomWord.Length; i++)
            {
                char char2Replace = randomWord[i];
                hiddenWord2Guess = hiddenWord2Guess.Replace(char2Replace, '_');
            }
            hiddenWord2GuessArray = hiddenWord2Guess.ToCharArray();
            Console.WriteLine(hiddenWord2GuessArray[0]);
            
        }
        


        
    }
}