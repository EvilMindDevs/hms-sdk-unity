using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.RemoteConfig
{
    public class ConfigValues : JavaObjectWrapper
    {

        public ConfigValues(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual bool containKey(string paramString) => Call<bool>("containKey", paramString);

        public virtual bool getValueAsBoolean(string paramString) => Call<bool>("getValueAsBoolean", paramString);

        public virtual byte[] getValueAsByteArray(string paramString) => Call<byte[]>("getValueAsByteArray", paramString);

        public virtual double getValueAsDouble(string paramString) => Call<double>("getValueAsDouble", paramString);

        public virtual long getValueAsLong(string paramString) => Call<long>("getValueAsLong", paramString);

        public virtual string getValueAsString(string paramString) => Call<string>("getValueAsString", paramString);
    }
}