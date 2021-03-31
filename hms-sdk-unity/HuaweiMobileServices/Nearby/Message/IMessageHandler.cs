using HuaweiMobileServices.Nearby.Discovery;
using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Nearby.Message
{
    public interface IMessageHandler
    {
        void OnBleSignalChanged(Message message, BleSignal bleSignal);
        void OnDistanceChanged(Message message, BleSignal bleSignal);
        void OnFound(Message message);
        void OnLost(Message message);
    }
}
