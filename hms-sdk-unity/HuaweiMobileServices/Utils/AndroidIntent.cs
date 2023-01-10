namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    //https://developer.android.com/reference/android/content/Intent
    public class AndroidIntent : JavaObjectWrapper
    {
        public AndroidIntent(AndroidJavaObject javaObject) : base(javaObject) { }

        public AndroidIntent(AndroidJavaClass activityClass) : base("android.content.Intent", AndroidContext.ActivityContext, activityClass) { }
        public AndroidIntent(string action) : base("android.content.Intent", action) { }
        public AndroidIntent() : base("android.content.Intent") { }

        public AndroidJavaObject Intent => JavaObject;

        public int GetIntExtra(string name) => Call<int>("getIntExtra", name, 1);

        public bool GetHasExtra(string name) => Call<bool>("hasExtra", name);

        public string GetStringExtra(string name) => CallAsString("getStringExtra", name);

        public bool GetBoolExtra(string name, bool defaultValue) => Call<bool>("getBooleanExtra", name, defaultValue);

        public AndroidBundle GetParcelableExtra<T>(string name) => CallAsWrapper<AndroidBundle>("getParcelableExtra", name);

        public AndroidIntent SetPackage(string packageName) => CallAsWrapper<AndroidIntent>("setPackage", packageName);
    }
}
