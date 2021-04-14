using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Void = HuaweiMobileServices.Utils.Void;

// com.huawei.hms.nearby.wifishare.WifiShareEngine wrapper
namespace HuaweiMobileServices.Nearby.WifiShare
{
    public class WifiShareEngine : JavaObjectWrapper
    {
        
        public WifiShareEngine(AndroidJavaObject javaObject) : base(javaObject) { }
        public ITask<Void> StartWifiSharee(WifiShareCallback callback, WifiSharePolicy policy) => CallAsWrapper<TaskVoidWrapper>("startWifiShare", callback, policy);
        public ITask<Void> StopWifiSharee() => CallAsWrapper<TaskVoidWrapper>("stopWifiShare");
        public ITask<Void> ShareWifiConfig(String endPointID) => CallAsWrapper<TaskVoidWrapper>("shareWifiConfig", endPointID);
    }
}
