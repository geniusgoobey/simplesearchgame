using System;
using System.IO;



namespace simplewordgame
{
    class Program
    { 
        static void Main(string[] args)
        {
            char[] chr_gameWord = getNewWord();

            char[] chr_puzzle = initialize_newGame(chr_gameWord);
                     
   

           
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
    }
}
