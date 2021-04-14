using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Crash
{
    class AGConnectCrashWrapper : JavaObjectWrapper, IAGConnectCrash
    {
        
        public AGConnectCrashWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public void EnableCrashCollection(bool enable) => Call("enableCrashCollection", enable);

        public void Log(string message) => Call("log", message);

        public void Log(int level, string message) => Call("log", level, message);

        public void SetCustomKey(string key, string value) => Call("setCustomKey", key, value);

        public void SetCustomKey(string key, bool value) => Call("setCustomKey", key, value);

        public void SetCustomKey(string key, double value) => Call("setCustomKey", key, value);

        public void SetCustomKey(string key, float value) => Call("setCustomKey", key, value);

        public void SetCustomKey(string key, int value) => Call("setCustomKey", key, value);

        public void SetCustomKey(string key, long value) => Call("setCustomKey", key, value);

        public void SetUserId(string userId) => Call("setUserId", userId);

        public void TestIt() => Call("testIt", AndroidContext.ApplicationContext);
        public void RecordException(AndroidJavaObject throwable) => Call("recordException", throwable);
    }
}
