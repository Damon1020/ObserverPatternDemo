using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternDemo
{
    interface IObserver
    {
         void ReceiveAndPrintData(TenXun tenXun);
    }
}
