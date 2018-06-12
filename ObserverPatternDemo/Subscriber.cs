using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternDemo
{
    //具体的订阅者类
    class Subscriber:IObserver
    {
        public string Name { get; set; }

        public Subscriber(string name)
        {
            this.Name = name;
        }

        public void ReceiveAndPrintData(TenXun tenXun)
        {
            Console.WriteLine("Notified {0} of {1}'s" + " Info is: {2}", Name, tenXun.Symbol, tenXun.Info);
        }
    }
}
