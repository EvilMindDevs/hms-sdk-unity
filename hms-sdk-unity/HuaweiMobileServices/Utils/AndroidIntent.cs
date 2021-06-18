namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    public class AndroidIntent : JavaObjectWrapper
    {
        public AndroidIntent(AndroidJavaObject javaObject) : base(javaObject) { }

        public AndroidIntent(AndroidJavaClass activityClass) : base("android.content.Intent", AndroidContext.ActivityContext, activityClass) { }

        public AndroidJavaObject Intent => JavaObject;

        public int GetIntExtra(string name) => Call<int>("getIntExtra", name, 1);

        public bool GetHasExtra(string name) => Call<bool>("hasExtra", name);

        public string GetStringExtra(string name) => CallAsString("getStringExtra", name);

        public bool GetBoolExtra(string name, bool defaultValue) => Call<bool>("getBooleanExtra", name, defaultValue);

        public AndroidBundle GetParcelableExtra<T>(string name) => CallAsWrapper<AndroidBundle>("getParcelableExtra", name);
    }
}
