using HuaweiMobileServices.Base;
using HuaweiMobileServices.Nearby.Transfer;
using HuaweiMobileServices.Utils;
using System;
using System.Threading.Tasks;
using UnityEngine;
using Void = HuaweiMobileServices.Utils.Void;

namespace HuaweiMobileServices.Nearby.Discovery
{
    //com.huawei.hms.nearby.discovery.DiscoveryEngine
    public class DiscoveryEngine : JavaObjectWrapper
    {
        
        public DiscoveryEngine(AndroidJavaObject javaObject) : base(javaObject) { }

        public ITask<Void> AcceptConnect(String endpointId, IDataCallback dataCallback) 
            => CallAsWrapper<TaskVoidWrapper>("acceptConnect", endpointId, new DataCallback(dataCallback));
        public void Disconnect(String endpointId) => Call("disconnect", endpointId);
        public ITask<Void> RejectConnect(String endpointId) 
                => CallAsWrapper<TaskVoidWrapper>("rejectConnect", endpointId);
        public ITask<Void> RequestConnect(String name, String endpointId, IConnectCallBack connectCallback)
                => CallAsWrapper<TaskVoidWrapper>("requestConnect", name, endpointId, new ConnectCallback(connectCallback));
        public ITask<Void> RequestConnectEx(String name, String endpointId, IConnectCallBack connectCallback, ConnectOption option)
                   => CallAsWrapper<TaskVoidWrapper>("requestConnectEx", name, endpointId, new ConnectCallback(connectCallback), option);
        public ITask<Void> StartBroadcasting(String name, String serviceId, IConnectCallBack connectCallback, BroadcastOption option) 
                => CallAsWrapper<TaskVoidWrapper>("startBroadcasting", name, serviceId, new ConnectCallback(connectCallback), option);
        public ITask<Void> StartScan(String serviceId, IScanEndpointCallback scanEndpointCallback, ScanOption option)
                => CallAsWrapper<TaskVoidWrapper>("startScan", serviceId, new ScanEndpointCallback(scanEndpointCallback), option);
        public void StopBroadcasting() => Call("stopBroadcasting");
        public void DisconnectAll() => Call("disconnectAll");
        public void StopScan() => Call("stopScan");

    }
}
