namespace HuaweiMobileServices.Ads
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class Location : JavaObjectWrapper
    {
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.android.location.Location");

        public static int FORMAT_DEGREES = sJavaClass.GetStatic<int>("FORMAT_DEGREES");
        public static int FORMAT_MINUTES = sJavaClass.GetStatic<int>("FORMAT_MINUTES");
        public static int FORMAT_SECONDS = sJavaClass.GetStatic<int>("FORMAT_SECONDS");

        public Location(string provider) : base("com.android.location.Location", provider) { }

        public Location(Location l) : base("com.android.location.Location", l.JavaObject) { }

        public Location(AndroidJavaObject javaObject) : base(javaObject) { }

        public float BearingTo(Location dest) => Call<float>("bearingTo", dest.JavaObject);

        public static string Convert(double coordinate, int outputType) => sJavaClass.CallStaticAsString("convert", coordinate, outputType);

        public static double Convert(string coordinate) => sJavaClass.CallStatic<double>("convert", coordinate);

        public int DescribeContents() => Call<int>("describeContents");

        public static void DistanceBetween(double startLatitude, double startLongitude, double endLatitude, double endLongitude, float[] results) 
            => sJavaClass.CallStatic("distanceBetween", startLatitude, startLongitude, endLatitude, endLongitude, results.AsJavaArray());

        public float DistanceTo(Location dest) => Call<float>("distanceTo", dest.JavaObject);

        // void	dump(Printer pw, String prefix) -- discarded due to redundant Printer class implementation

        public bool Equals(AndroidJavaObject obj) => Call<bool>("equals", obj);

        public float GetAccuracy() => Call<float>("getAccuracy");

        public double GetAltitude() => Call<double>("getAltitude");

        public float GetBearing() => Call<float>("getBearing");

        public float GetBearingAccuracyDegrees() => Call<float>("getBearingAccuracyDegrees");

        public long GetElapsedRealtimeNanos() => Call<long>("getElapsedRealtimeNanos");

        public double GetElapsedRealtimeUncertaintyNanos() => Call<double>("getElapsedRealtimeUncertaintyNanos");

        public AndroidBundle GetExtras() => CallAsWrapper<AndroidBundle>("getExtras");

        public double GetLatitude() => Call<double>("getLatitude");

        public double GetLongitude() => Call<double>("getLongitude");

        public string GetProvider() => Call<string>("getProvider");

        public float GetSpeed() => Call<float>("getSpeed");

        public float GetSpeedAccuracyMetersPerSecond() => Call<float>("getSpeedAccuracyMetersPerSecond");

        public long GetTime() => Call<long>("getTime");

        public float GetVerticalAccuracyMeters() => Call<float>("getVerticalAccuracyMeters");

        public bool HasAccuracy() => Call<bool>("hasAccuracy");

        public bool HasAltitude() => Call<bool>("hasAltitude");

        public bool HasBearing() => Call<bool>("hasBearing");

        public bool HasBearingAccuracy() => Call<bool>("hasBearingAccuracy");

        public bool HasElapsedRealtimeUncertaintyNanos() => Call<bool>("hasElapsedRealtimeUncertaintyNanos");

        public bool HasSpeed() => Call<bool>("hasSpeed");

        public bool HasSpeedAccuracy() => Call<bool>("hasSpeedAccuracy");

        public bool HasVerticalAccuracy() => Call<bool>("hasVerticalAccuracy");

        public int HashCode() => Call<int>("hashCode");

        public bool IsFromMockProvider() => Call<bool>("isFromMockProvider");

        public bool IsMock() => Call<bool>("isMock");

        public void RemoveAccuracy() => Call("removeAccuracy");

        public void RemoveAltitude() => Call("removeAltitude");

        public void RemoveBearing() => Call("removeBearing");

        public void RemoveSpeed() => Call("removeSpeed");

        public void Reset() => Call("reset");

        public void Set(Location l) => Call("set", l.JavaObject);

        public void SetAccuracy(float horizontalAccuracy) => Call("setAccuracy", horizontalAccuracy);
        
        public void SetAltitude(double altitude) => Call("setAltitude", altitude);

        public void SetBearing(float bearing) => Call("setBearing", bearing);

        public void SetBearingAccuracyDegrees(float bearingAccuracyDegrees) => Call("setBearingAccuracyDegrees", bearingAccuracyDegrees);

        public void SetElapsedRealtimeNanos(long time) => Call("setElapsedRealtimeNanos", time);

        public void SetElapsedRealtimeUncertaintyNanos(double time) => Call("setElapsedRealtimeUncertaintyNanos", time);

        public void SetExtras(AndroidBundle extras) => Call("setExtras", extras.JavaObject);

        public void SetLatitude(double latitude) => Call("setLatitude", latitude);

        public void SetLongitude(double longitude) => Call("setLongitude", longitude);

        public void SetMock(bool mock) => Call("setMock", mock);

        public void SetProvider(string provider) => Call("setProvider", provider);

        public void SetSpeed(float speed) => Call("setSpeed", speed);

        public void SetSpeedAccuracyMetersPerSecond(float speedAccuracyMeterPerSecond) => Call("setSpeedAccuracyMetersPerSecond", speedAccuracyMeterPerSecond);

        public void SetTime(long time) => Call("setTime", time);

        public void SetVerticalAccuracyMeters(float verticalAccuracyMeters) => Call("setVerticalAccuracyMeters", verticalAccuracyMeters);

        public string ToString() => CallAsString("toString"); // needs double check

        // void writeToParcel(Parcel parcel, int flags) -- discarded due to redundant Parcel class implementation

    }
}
