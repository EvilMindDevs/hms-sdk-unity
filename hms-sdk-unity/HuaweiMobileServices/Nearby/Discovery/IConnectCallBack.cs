
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Discovery
{
    public  interface IConnectCallBack
    {
         void onEstablish(string p0, AndroidJavaObject p1);
         void onResult(string p0, AndroidJavaObject p1);
         void onDisconnected(string p0);
    }
}
