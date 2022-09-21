using HuaweiMobileServices.Utils;

using UnityEngine;

namespace HuaweiMobileServices.APM
{
    public class AddCustomTrace : JavaObjectWrapper
    {
        public AddCustomTrace(AndroidJavaObject javaObject) : base(javaObject) { }
        public AddCustomTrace() : base("com.huawei.agconnect.apms.instrument.AddCustomTrace") { }
        public string Name() => CallAsString("name");
        public bool Enabled() => Call<bool>("enabled");
    }
}