using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Transfer
{
    public interface IDataCallback
    {
        void onReceived(String endpointId, Data data);
        void onTransferUpdate(String endpointId, TransferStateUpdate update);
    }
}
