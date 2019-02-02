using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4_solved
{
    class Program
    {
        static int HighScore = 300;
        static string HighScorePlayer = "Sebastian";

        static void Main(string[] args)
        {
            CheckHighScore(100, "Cassie");
            CheckHighScore(200, "Patrick");
            CheckHighScore(310, "Patrick");
            CheckHighScore(325, "Sebastian");
            Console.Read();
        }

        public static void CheckHighScore (int score, string PlayerName)
        {
            if (score > HighScore)
            {
                HighScore = score;
                HighScorePlayer = PlayerName;

                Console.WriteLine("New High Score is: " + HighScore);
                Console.WriteLine("The High Score is now held by: " + HighScorePlayer);
            }
            else
            {
                Console.WriteLine("You did not break the old high score. It is still: " +HighScore);
                Console.WriteLine("and held by: " +HighScorePlayer);
            }
        }
    }
}
