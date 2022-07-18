using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Location.Location
{
    public class HWLocation : JavaObjectWrapper
    {
        public HWLocation(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.HWLocation");

        //Creator field

        public HWLocation() : base("com.huawei.hms.location.HWLocation") { }

        public int GetConversionType => Call<int>("getConversionType");

        public float GetAccuracy => Call<float>("getAccuracy");

        public double GetAltitude => Call<double>("getAltitude");

        public float GetBearing() => Call<float>("getBearing");

        public float GetBearingAccuracyDegrees() => Call<float>("getBearingAccuracyDegrees");

        public string GetCity() => CallAsString("getCity");

        public string GetCountryCode() => CallAsString("getCountryCode");

        public string GetCountryName() => CallAsString("getCountryName");

        public string GetCounty() => CallAsString("getCounty");

        public long GetElapsedRealtimeNanos() => Call<long>("getElapsedRealtimeNanos");

        public Map<string, Object> GetExtraInfo() => CallAsWrapper<Map<string, Object>>("getExtraInfo");

        public string GetFeatureName() => CallAsString("getFeatureName");

        public double GetLatitude() => Call<double>("getLatitude");

        public double GetLongitude() => Call<double>("getLongitude");

        public string GetPhone() => CallAsString("getPhone");

        public string GetPostalCode() => CallAsString("getPostalCode");

        public string GetProvider() => CallAsString("getProvider");

        public float GetSpeed() => Call<float>("getSpeed");

        public float GetSpeedAccuracyMetersPerSecond() => Call<float>("getSpeedAccuracyMetersPerSecond");

        public string GetState() => CallAsString("getState");

        public string GetStreet() => CallAsString("getStreet");

        public long GetTime() => Call<long>("getTime");

        public string GetUrl() => CallAsString("getUrl");

        public float GetVerticalAccuracyMeters() => Call<float>("getVerticalAccuracyMeters");

        public void SetAccuracy(float mHorizontalAccuracy) => Call("setAccuracy", mHorizontalAccuracy);

        public void SetAltitude(double mAltitude) => Call("setAltitude", mAltitude);

        public void SetBearing(float mBearing) => Call("setBearing", mBearing);

        public void SetBearingAccuracyDegrees(float mBearingAccuracy) => Call("setBearingAccuracyDegrees", mBearingAccuracy);

        public void SetCity(string mCity) => Call("setCity", mCity.AsJavaString());

        public void SetCountryCode(string mCountryCode) => Call("setCountryCode", mCountryCode.AsJavaString());

        public void SetCountryName(string mCountryName) => Call("setCountryName", mCountryName.AsJavaString());

        public void SetCounty(string mCounty) => Call("setCounty", mCounty.AsJavaString());

        public void SetElapsedRealtimeNanos(long mElapsedRealtimeNanos) => Call("setElapsedRealtimeNanos", mElapsedRealtimeNanos);

        public void SetExtraInfo(Map<string, Object> extraInfo) => Call("setExtraInfo", extraInfo);

        public void SetFeatureName(string mFeatureName) => Call("setFeatureName", mFeatureName.AsJavaString());

        public void SetLatitude(double mLatitude) => Call("setLatitude", mLatitude);

        public void SetLongitude(double mLongitude) => Call("setLongitude", mLongitude);

        public void SetPhone(string mPhone) => Call("setPhone", mPhone.AsJavaString());

        public void SetPostalCode(string mPostalCode) => Call("setPostalCode", mPostalCode.AsJavaString());

        public void SetProvider(string mProvider) => Call("setProvider", mProvider.AsJavaString());

        public void SetSpeed(float mSpeed) => Call("setSpeed", mSpeed);

        public void SetSpeedAccuracyMetersPerSecond(float mSpeedAccuracy) => Call("setSpeedAccuracyMetersPerSecond", mSpeedAccuracy);

        public void SetState(string mState) => Call("setState", mState.AsJavaString());

        public void SetStreet(string mStreet) => Call("setStreet", mStreet.AsJavaString());

        public void SetTime(long mTime) => Call("setTime", mTime);

        public void SetUrl(string mUrl) => Call("setUrl", mUrl.AsJavaString());

        public void SetVerticalAccuracyMeters(float mVerticalAccuracy) => Call("setVerticalAccuracyMeters", mVerticalAccuracy);

    }
}
