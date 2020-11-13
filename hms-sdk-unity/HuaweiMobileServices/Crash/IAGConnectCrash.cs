using System;

namespace HuaweiMobileServices.Crash
{
    public interface IAGConnectCrash
    {
        void EnableCrashCollection(Boolean enable);
        void TestIt();
        void SetUserId(String userId);
        void SetCustomKey(String key, String value);
        void SetCustomKey(String key, Boolean value);
        void SetCustomKey(String key, double value);
        void SetCustomKey(String key, float value);
        void SetCustomKey(String key, int value);
        void SetCustomKey(String key, long value);
        void Log(String message);
        void Log(int level, String message);
    }
}
