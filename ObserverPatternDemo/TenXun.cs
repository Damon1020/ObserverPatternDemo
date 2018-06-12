using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternDemo
{
    //订阅号抽象类
    abstract class TenXun
    {
        //保存订阅者列表
        private List<IObserver> Subscribers = new List<IObserver>();

        public string Symbol { get; set; }

        public string Info { get; set; }

        public TenXun(string symbol,string info)
        {
            this.Symbol = symbol;
            this.Info = info;
        }

        #region 新增对订阅号列表的维护操作
        public void AddObserver(IObserver ob)
        {
            Subscribers.Add(ob);
        }
        public void RemoveObserver(IObserver ob)
        {
            Subscribers.Remove(ob);
        }
        #endregion

        public void Update()
        {
            foreach(IObserver ob in Subscribers)
                ob?.ReceiveAndPrintData(this);
        }
    }
}
