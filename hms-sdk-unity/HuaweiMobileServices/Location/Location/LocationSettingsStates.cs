using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Location.Location
{
    public class LocationSettingsStates : JavaObjectWrapper
    {
        public LocationSettingsStates(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.LocationSettingsStates");

        public LocationSettingsStates() : base("com.huawei.hms.location.LocationSettingsStates") { }

        public static LocationSettingsStates FromIntent(AndroidIntent intent)
        => javaClass.CallStaticAsWrapper<LocationSettingsStates>("fromIntent", intent);

        public bool IsBleUsable() => Call<bool>("isBleUsable");

        public bool IsGnssPresent() => Call<bool>("isGnssPresent");

        public bool IsGnssUsable() => Call<bool>("isGnssUsable");

        public bool IsHMSLocationPresent() => Call<bool>("isHMSLocationPresent");

        public bool IsHMSLocationUsable() => Call<bool>("isHMSLocationUsable");

        public bool IsLocationPresent() => Call<bool>("isLocationPresent");

        public bool IsLocationUsable() => Call<bool>("isLocationUsable");

        public bool IsNetworkLocationPresent() => Call<bool>("isNetworkLocationPresent");

        public bool IsNetworkLocationUsable() => Call<bool>("isNetworkLocationUsable");

        public void SetBlePresent(bool blePresent) => Call("setBlePresent", blePresent);

        public void SetBleUsable(bool bleUsable) => Call("setBleUsable", bleUsable);

        public void SetGnssPresent(bool gnssPresent) => Call("setGnssPresent", gnssPresent);

        public void SetGnssUsable(bool gnssUsable) => Call("setGnssUsable", gnssUsable);

        public void SetHMSLocationPresent(bool hmsLocationPresent)
            => Call("setHMSLocationPresent", hmsLocationPresent);

        public void SetHMSLocationUsable(bool hmsLocationUsable)
            => Call("setHmsLocationUsable", hmsLocationUsable);

        public void SetLocationPresent(bool locationPresent)
            => Call("setLocationPresent", locationPresent);

        public void SetLocationUsable(bool locationUsable)
            => Call("setLocationUsable", locationUsable);

        public void SetNetworkLocationPresent(bool networkLocationPresent)
            => Call("setNetworkLocationPresent", networkLocationPresent);

        public void SetNetworkLocationUsable(bool networkLocationUsable)
            => Call("setNetworkLocationUsable", networkLocationUsable);
    }
}





