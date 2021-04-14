using UnityEngine;
using System.Collections;
using HuaweiMobileServices.Utils;
using System.Threading.Tasks;
using System.Collections.Generic;
using HuaweiMobileServices.Base;

namespace HuaweiMobileServices.Nearby.Transfer
{
    //com.huawei.hms.nearby.transfer.TransferEngine
    public class TransferEngine : JavaObjectWrapper
    {
        
        public TransferEngine(AndroidJavaObject javaObject) : base(javaObject) { }
        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.transfer.TransferEngine");
        public static int MAX_SIZE_DATA => androidJavaClass.GetStatic<int>("MAX_SIZE_DATA");

        public ITask<Void> CancelDataTransfer(long dataId) => CallAsWrapper<TaskVoidWrapper>("cancelDataTransfer", dataId);

        public ITask<Void> SendData(System.String endpointId, Data data) => CallAsWrapper<TaskVoidWrapper>("sendData", endpointId,data);

        public ITask<Void> SendData(List<System.String> endpointIds, Data data) => CallAsWrapper<TaskVoidWrapper>("sendData", endpointIds, data);
    }
}