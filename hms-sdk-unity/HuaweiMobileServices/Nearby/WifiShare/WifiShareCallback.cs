using HuaweiMobileServices.Nearby.Discovery;
using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.WifiShare
{ 
    public class WifiShareCallback : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public WifiShareCallback(AndroidJavaObject javaObject) : base(javaObject) { }

        public static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.wifishare.WifiShareCallback");
        public void OnFound(String endpointId, ScanEndpointInfo info) => androidJavaClass.Call("onFound", endpointId, info);
        public void OnLost(String endpointId) => androidJavaClass.Call("onLost", endpointId);
        public void OnFetchAuthCode(String endpointId, String authCode) => androidJavaClass.Call("onFetchAuthCode", endpointId, authCode);
        public void OnWifiShareResult(String endpointId, int statusCode) => androidJavaClass.Call("onWifiShareResult", endpointId, statusCode);


    }
}
