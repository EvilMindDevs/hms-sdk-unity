using System.Collections.Generic;
using System.IO;

namespace com.huawei.agconnect.config
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.agconnect.config.AGConnectServicesConfig
    public class AGConnectServicesConfig : JavaObjectWrapper
    {

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.agconnect.config.AGConnectServicesConfig");

        public AGConnectServicesConfig(AndroidJavaObject javaObject) : base(javaObject) { }

        public static AGConnectServicesConfig FromContext() =>
            sJavaClass.CallStaticAsWrapper<AGConnectServicesConfig>("fromContext", AndroidContext.GetApplicationContext());

        public virtual bool GetBoolean(string path) => Call<bool>("getBoolean", path);

        public virtual bool GetBoolean(string path, bool def) => Call<bool>("getBoolean", path, def);

        public virtual int GetInt(string path) => Call<int>("getInt", path);

        public virtual int GetInt(string path, int def) => Call<int>("getInt", path, def);

        public virtual string GetString(string path) => CallAsString("getInt", path);

        public virtual string GetString(string path, string def) => CallAsString("getString", path);
    }
}