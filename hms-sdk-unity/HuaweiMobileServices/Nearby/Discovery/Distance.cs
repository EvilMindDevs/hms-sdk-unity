using HuaweiMobileServices.Utils;

namespace HuaweiMobileServices.Nearby.Discovery
{
    public class Distance : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public Distance() : base("com.huawei.hms.nearby.discovery.Distance") { }
        public int Precision => Call<int>("getPrecision");
        public int Meters => Call<int>("getMeters");
    }
}