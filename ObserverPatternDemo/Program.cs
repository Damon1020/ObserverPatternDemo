using System;

namespace ObserverPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TenxunGame txGame = new TenxunGame();
            Subscriber LearningHardSub = new Subscriber("LearningHard");
            txGame.Subscriber = LearningHardSub;
            txGame.Symbol = "TenXun Game";
            txGame.Info = "A new game published !";
            txGame.Update();

            Console.ReadKey();
        }
    }
}
