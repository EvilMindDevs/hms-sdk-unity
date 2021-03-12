﻿using HuaweiMobileServices.Utils;
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
        public BeaconId Parse(Message messsage) => androidJavaClass.CallStaticAsWrapper<BeaconId>("parse", messsage);
        public String ToStringBeacon => androidJavaClass.Call<String>("toString");
        public String Hex => androidJavaClass.Call<String>("getHex");
        public String Instance => androidJavaClass.Call<String>("getInstance");
        public String NameSpace => androidJavaClass.Call<String>("getNamespace");
        public short Major => androidJavaClass.Call<short>("getMajor");
        public short Minor => androidJavaClass.Call<short>("getMinor");
        public AndroidJavaObject BeaconUuid => androidJavaClass.Call<AndroidJavaObject>("getBeaconUuid");


        public class Builder : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.nearby.message.BeaconId$Builder") { }
            public BeaconId Build() => CallAsWrapper<BeaconId>("build");
            public Builder SetIBeaconUuid(AndroidJavaObject IBeaconUuid) => CallAsWrapper<Builder>("setIBeaconUuid", IBeaconUuid);
            public Builder SetMajor(short major) => CallAsWrapper<Builder>("setMajor", major);
            public Builder SetMinor(short minor) => CallAsWrapper<Builder>("setMinor", minor);
            public Builder SetHexId(String hexId) => CallAsWrapper<Builder>("setHexId", hexId);
            public Builder SetHexNamespace(String hexNamespace) => CallAsWrapper<Builder>("setHexNamespace", hexNamespace);
            public Builder SetHexInstance(String hexInstance) => CallAsWrapper<Builder>("setHexInstance", hexInstance);

        }
    }
}