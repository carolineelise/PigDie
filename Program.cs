using System;

namespace PigDie
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pd = new pigdie();
            var newhighScore = pd.RunToHighScore(1000);
            var highScore = 0;
            for (var idx = 0; idx < 100; idx++)
            {
              var score = pd.PlayPigDice();
                if (score > highScore)
                {
                  highScore = score;
                    Console.WriteLine($"New high score is {newhighScore}");
                }
            }
        }
    }
}
