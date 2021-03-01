using HuaweiMobileServices.Base;
using HuaweiMobileServices.Nearby.Transfer;
using HuaweiMobileServices.Utils;
using System;
using System.Threading.Tasks;
using UnityEngine;
using Void = HuaweiMobileServices.Utils.Void;

namespace HuaweiMobileServices.Nearby.Discovery
{
    public class DiscoveryEngine : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public DiscoveryEngine(AndroidJavaObject javaObject) : base(javaObject) { }

        public static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.discovery.DiscoveryEngine");
        public ITask<Void> AcceptConnect(String endpointId, IDataCallback dataCallback) 
            => CallAsWrapper<TaskVoidWrapper>("acceptConnect", endpointId, new DataCallback(dataCallback));
        public void Disconnect(String endpointId) => androidJavaClass.Call("disconnect", endpointId);
        public ITask<Void> RejectConnect(String endpointId) 
                => CallAsWrapper<TaskVoidWrapper>("rejectConnect", endpointId);
        public ITask<Void> RequestConnect(String endpointId, String name, IConnectCallBack connectCallback) 
                => CallAsWrapper<TaskVoidWrapper>("requestConnect", name, endpointId, new ConnectCallback(connectCallback));
        public ITask<Void> StartBroadcasting(String name, String serviceId, IConnectCallBack connectCallback, BroadcastOption option) 
                => CallAsWrapper<TaskVoidWrapper>("startBroadcasting", name, serviceId, new ConnectCallback(connectCallback), option);
        public ITask<Void> StartScan(String serviceId, IScanEndpointCallback scanEndpointCallback, ScanOption option)
                => CallAsWrapper<TaskVoidWrapper>("startScan", serviceId, new ScanEndpointCallback(scanEndpointCallback), option);
        public void StopBroadcasting() => androidJavaClass.Call("stopBroadcasting");
        public void DisconnectAll() => androidJavaClass.Call("disconnectAll");
        public void StopScan() => androidJavaClass.Call("stopScan");


    }
}
