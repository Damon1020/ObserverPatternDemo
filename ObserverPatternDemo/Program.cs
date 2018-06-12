using System;

namespace ObserverPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //TenxunGame txGame = new TenxunGame();
            //Subscriber LearningHardSub = new Subscriber("LearningHard");
            //txGame.Subscriber = LearningHardSub;
            //txGame.Symbol = "TenXun Game";
            //txGame.Info = "A new game published !";
            //txGame.Update();

            TenXun tenXun = new TenxunGame("TenXun Game", "TenXun Game published a very fun game,come on and play!");
            tenXun.AddObserver(new Subscriber("Damon"));
            tenXun.AddObserver(new Subscriber("Elena"));
            tenXun.Update();

            Console.ReadKey();
        }
    }
}
