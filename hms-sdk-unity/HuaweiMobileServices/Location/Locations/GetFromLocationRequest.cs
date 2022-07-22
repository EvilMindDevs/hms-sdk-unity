using HuaweiMobileServices.Utils;
using UnityEngine;


namespace HuaweiMobileServices.Location.Location
{
    public class GetFromLocationRequest : JavaObjectWrapper
    {
        public GetFromLocationRequest(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.GetFromLocationRequest");

        public GetFromLocationRequest(double latitude, double longitude, int maxResults)
   : base("com.huawei.hms.location.GeocoderService", latitude, longitude, maxResults) { }

        public double GetLatitude => Call<double>("getLatitude");

        public double GetLongitude => Call<double>("getLongitude");

        public int GetMaxResults => Call<int>("getMaxResults");

        public void SetLatitude(double latitude) => Call("setLatitude", latitude);

        public void SetLongitude(double longitude) => Call("setLongitude", longitude);

        public void SetMaxResults(int locationName) => Call("setMaxResults", locationName);

    }
}