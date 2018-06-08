using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternDemo
{
    // 腾讯游戏订阅号类
    class TenxunGame
    {
        //订阅者对象
        public Subscriber Subscriber { get; set; }

        public string Symbol { get; set; }

        public string Info { get; set; }

        public void Update()
        {
            Subscriber?.ReceiveAndPrintData(this);
        }
    }
}
