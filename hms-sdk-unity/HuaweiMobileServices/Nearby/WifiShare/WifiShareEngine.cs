using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Void = HuaweiMobileServices.Utils.Void;

namespace HuaweiMobileServices.Nearby.WifiShare
{
   public class WifiShareEngine : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public WifiShareEngine(AndroidJavaObject javaObject) : base(javaObject) { }

        public static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.wifishare.WifiShareEngine");

        public Task<Void> StartWifiSharee(WifiShareCallback callback, WifiSharePolicy policy)
                            => androidJavaClass.Call<Task<Void>>("startWifiShare", callback, policy);
        public Task<Void> StopWifiSharee()
                    => androidJavaClass.Call<Task<Void>>("stopWifiShare");
        public Task<Void> ShareWifiConfig(String endPointID)
                => androidJavaClass.Call<Task<Void>>("shareWifiConfig", endPointID);
    }
}
