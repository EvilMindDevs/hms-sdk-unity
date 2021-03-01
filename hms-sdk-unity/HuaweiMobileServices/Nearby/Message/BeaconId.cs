using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Message
{
    class BeaconId : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public BeaconId(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.message.BeaconId");
        public static int BEACON_TYPE_IBEACON => androidJavaClass.GetStatic<int>("BEACON_TYPE_IBEACON");
        public static int BEACON_TYPE_EDDYSTONE_UID => androidJavaClass.GetStatic<int>("BEACON_TYPE_EDDYSTONE_UID");
        public static int IBEACON_ID_LENGTH => androidJavaClass.GetStatic<int>("IBEACON_ID_LENGTH");
        public static int EDDYSTONE_UID_LENGTH => androidJavaClass.GetStatic<int>("EDDYSTONE_UID_LENGTH");
        public static int EDDYSTONE_NAMESPACE_LENGTH => androidJavaClass.GetStatic<int>("EDDYSTONE_NAMESPACE_LENGTH");
        public static int EDDYSTONE_INSTANCE_LENGTH => androidJavaClass.GetStatic<int>("EDDYSTONE_INSTANCE_LENGTH");
        public int Length => androidJavaClass.Call<int>("getLength");
        public int Type => androidJavaClass.Call<int>("getType");
        public bool Equals(AndroidJavaObject androidJavaObject)=> androidJavaClass.Call<bool>("equals", androidJavaObject);
        public BeaconId Parse(Message messsage) => androidJavaClass.CallStatic<BeaconId>("parse", messsage);
        public int HashCode => androidJavaClass.Call<int>("hashCode");
        public String ToStringBeacon => androidJavaClass.Call<String>("toString");
        public String Hex => androidJavaClass.Call<String>("getHex");
        public String Instance => androidJavaClass.Call<String>("getInstance");
        public String NameSpace => androidJavaClass.Call<String>("getNamespace");
        public short Major => androidJavaClass.Call<short>("getMajor");
        public short Minor => androidJavaClass.Call<short>("getMinor");
        public UUID BeaconUuid => androidJavaClass.Call<UUID>("getBeaconUuid");


        public class Builder : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.nearby.message.BeaconId$Builder") { }
            public BeaconId Build() => CallAsWrapper<BeaconId>("build");
            public Builder SetIBeaconUuid(UUID IBeaconUuid) => Call<Builder>("setIBeaconUuid", IBeaconUuid);
            public Builder SetMajor(short major) => Call<Builder>("setMajor", major);
            public Builder SetMinor(short minor) => Call<Builder>("setMinor", minor);
            public Builder SetHexId(String hexId) => Call<Builder>("setHexId", hexId);
            public Builder SetHexNamespace(String hexNamespace) => Call<Builder>("setHexNamespace", hexNamespace);
            public Builder SetHexInstance(String hexInstance) => Call<Builder>("setHexInstance", hexInstance);

        }
    }
}
