namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    //https://developer.android.com/reference/android/content/Intent
    public class AndroidIntent : JavaObjectWrapper
    {
        private const string CLASS_NAME = "android.content.Intent";
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);
        public AndroidIntent(AndroidJavaObject javaObject) : base(javaObject) { }
        public AndroidIntent(AndroidJavaClass activityClass) : base(CLASS_NAME, AndroidContext.ActivityContext, activityClass) { }
        public AndroidIntent(string action) : base(CLASS_NAME, action) { }
        public AndroidIntent() : base(CLASS_NAME) { }

        public AndroidJavaObject Intent => JavaObject;

        public static int FLAG_GRANT_READ_URI_PERMISSION => sJavaClass.GetStaticFieldCached<int>("FLAG_GRANT_READ_URI_PERMISSION"); //1
        public static int FLAG_GRANT_WRITE_URI_PERMISSION => sJavaClass.GetStaticFieldCached<int>("FLAG_GRANT_WRITE_URI_PERMISSION"); //2
        public static int URI_ALLOW_UNSAFE => sJavaClass.GetStaticFieldCached<int>("URI_ALLOW_UNSAFE"); //4
        public static int FLAG_GRANT_PERSISTABLE_URI_PERMISSION => sJavaClass.GetStaticFieldCached<int>("FLAG_GRANT_PERSISTABLE_URI_PERMISSION"); //64
        public static int FLAG_GRANT_PREFIX_URI_PERMISSION => sJavaClass.GetStaticFieldCached<int>("FLAG_GRANT_PREFIX_URI_PERMISSION"); //128



        public int GetIntExtra(string name) => Call<int>("getIntExtra", name, 1);

        public bool GetHasExtra(string name) => Call<bool>("hasExtra", name);

        public string GetStringExtra(string name) => CallAsString("getStringExtra", name);

        public bool GetBoolExtra(string name, bool defaultValue) => Call<bool>("getBooleanExtra", name, defaultValue);

        public AndroidBundle GetParcelableExtra<T>(string name) => CallAsWrapper<AndroidBundle>("getParcelableExtra", name);

        public AndroidIntent SetPackage(string packageName) => CallAsWrapper<AndroidIntent>("setPackage", packageName);

        public AndroidIntent PutExtra(string name, string value) => CallAsWrapper<AndroidIntent>("putExtra", name, value);

        public AndroidIntent PutExtra(string name, bool value) => CallAsWrapper<AndroidIntent>("putExtra", name, value);

        public AndroidIntent PutExtra(string name, byte value) => CallAsWrapper<AndroidIntent>("putExtra", name, value);

        public AndroidIntent PutExtra(string name, int value) => CallAsWrapper<AndroidIntent>("putExtra", name, value);
        public AndroidIntent AddCategory(string name) => CallAsWrapper<AndroidIntent>("addCategory", name);
        public AndroidIntent AddFlags(int flag) => CallAsWrapper<AndroidIntent>("addFlags", flag);
        public AndroidIntent SetType(string type) => CallAsWrapper<AndroidIntent>("setType", type);
        public Uri GetData() => CallAsWrapper<Uri>("getData");
        public string GetDataString() => CallAsString("getDataString");
    }
}
