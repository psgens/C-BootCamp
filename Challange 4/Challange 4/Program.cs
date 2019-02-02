using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_4
{
    class Program
    {
        public static int Score;
        public static string InputScore;
        public static string Playername;
        public static string HighScorePlayer;

        static void Main(string[] args)
        {
            
            int HighScore = 300;
            HighScorePlayer = "Sebastian";
            PName();
            PScore();
            bool HighScoreCheck = Score > HighScore;

            if (HighScoreCheck)
            {
                switch (Playername)
                {
                    case ("Sebastian"):

                        Console.WriteLine(Playername + ", you had the previous High Score");
                        HighScore = Score;
                        Console.WriteLine("Your new High Score is: " + HighScore);
                        break;
                    default:
                        HighScorePlayer = Playername;
                        Console.WriteLine(HighScorePlayer + " is the new High Score Player!");
                        HighScore = Score;
                        break;
                }
            }
            else
            {
                Console.WriteLine("You did not beat the High Score.");
            }
            Console.Read();
        }

        public static string PName()
        {
            Console.WriteLine("What's your name?");
            Playername = Console.ReadLine();
            return Playername;
        }

        public static int PScore()
        {
            Console.WriteLine("What was your score?");
        
        InputScore = Console.ReadLine();
        Score = Int32.Parse(InputScore);
            return Score;
        }
    }
}
