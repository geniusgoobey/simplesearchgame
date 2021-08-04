using System;
using System.IO;



namespace simplewordgame
{
    class Program
    { 
        static void Main(string[] args)
        {

            //windy
            //w_____
            char[] chr_gameWord = getNewWord();
            char[] chr_puzzle = initialize_newGame(chr_gameWord);
            char key;
            string str;
            int count = 0;
            Console.WriteLine(chr_gameWord);
            Console.WriteLine("Welcome \n");

            do
            {
                Console.WriteLine("\n");
                Console.WriteLine(chr_puzzle);
                //write code here to sanitize the input and check if it's in between A-Z
                key = char.ToUpper(Console.ReadKey().KeyChar);

                for (int i = 0; i < chr_gameWord.Length; i++)
                {
                    if (chr_gameWord[i] == key)
                    {

                        chr_puzzle[i] = key;
                    }

                }
                count++;

                str = new string(chr_puzzle);

            } while (str.Contains("_"));



            Console.WriteLine("\nThe word is " + str + "\n");
            Console.WriteLine("You guessed the word in " + count + " attempts.");

        }

        private static char[] initialize_newGame(char[] chr_gameWord)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            char[] puzzle = new char[chr_gameWord.Length];
            int size = (int) Math.Round(chr_gameWord.Length * 0.2);
           // int[] pos = new int[size];
            int pos = 0;
            for (int i = 0; i < chr_gameWord.Length; i++)
            {
                puzzle[i] = '_';

            }
            
            for (int i = 0; i< size; i++)
            {
                pos = rnd.Next(0, chr_gameWord.Length);
                puzzle[pos] = chr_gameWord[pos];

            }

            return puzzle;

        }

        private static char[]  getNewWord()
        {

            string[] wordList = File.ReadAllLines(@"C:\Users\Sridhar\source\repos\simplesearchgame\simplewordgame\simplewordgame\wordlist.txt");
            Random rnd = new Random(DateTime.Now.Millisecond);
            int wordIndex = rnd.Next(1, wordList.Length);
            return wordList[wordIndex].ToUpper().ToCharArray();

        }

        private static void printWord()
        {
        }

    }
}
