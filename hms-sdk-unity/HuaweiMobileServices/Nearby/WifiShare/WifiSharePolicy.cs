using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.WifiShare
{
   public class WifiSharePolicy : JavaObjectWrapper
   {
        
        public WifiSharePolicy(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.wifishare.WifiSharePolicy");
        public static WifiSharePolicy POLICY_MESH => androidJavaClass.GetStatic<WifiSharePolicy>("POLICY_SHARE");
        public static WifiSharePolicy POLICY_SET => androidJavaClass.GetStatic<WifiSharePolicy>("POLICY_SET");
   }
}
