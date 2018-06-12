using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternDemo
{
    // 具体订阅号类
    class TenxunGame:TenXun
    {
        public TenxunGame(string symbol,string info)
            : base(symbol,info)
        {

        }
        
    }
}
