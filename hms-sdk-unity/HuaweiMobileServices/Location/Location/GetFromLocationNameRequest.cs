using HuaweiMobileServices.Utils;
using UnityEngine;


namespace HuaweiMobileServices.Location.Location
{
    public class GetFromLocationNameRequest : JavaObjectWrapper
    {
        public GetFromLocationNameRequest(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.GetFromLocationNameRequest");

        public GetFromLocationNameRequest(string locationName, int maxResult) : base("com.huawei.hms.location.GetFromLocationNameRequest", locationName, maxResult) { }

        public GetFromLocationNameRequest
            (string locationName, int maxResults, double lowerLeftLatitude, double lowerLeftLongitude, double upperRightLatitude, double upperRightLongitude)
            : base("com.huawei.hms.location.GetFromLocationNameRequest", locationName, maxResults, lowerLeftLatitude, lowerLeftLongitude, upperRightLatitude, upperRightLongitude) { }

        public string GetLocationName => Call<string>("getLocationName");

        public double GetLowerLeftLatitude => Call<double>("getLowerLeftLatitude");

        public double GetLowerLeftLongitude => Call<double>("getLowerLeftLongitude");

        public int GetMaxResults => Call<int>("getMaxResults");

        public double GetUpperRightLatitude => Call<double>("getUpperRightLatitude");

        public double GetUpperRightLongitude => Call<double>("getUpperRightLongitude");

        public void SetLocationName(string locationName) => Call("setLocationName", locationName.AsJavaString());

        public void SetLowerLeftLatitude(double lowerLeftLatitude) => Call("setLowerLeftLatitude", lowerLeftLatitude);

        public void SetLowerLeftLongitude(double lowerLeftLongitude) => Call("setLowerLeftLongitude", lowerLeftLongitude);

        public void SetMaxResults(int maxResults) => Call("setMaxResults", maxResults);

        public void SetUpperRightLatitude(double upperRightLatitude) => Call("setUpperRightLatitude", upperRightLatitude);

        public void SetUpperRightLongitude(double upperRightLongitude) => Call("setUpperRightLongitude", upperRightLongitude);

    }
}