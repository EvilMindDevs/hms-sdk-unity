using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Location
{
    public interface ILocationBroadcastListener
    {
        void OnReceive(AndroidIntent intent);
    }
}
