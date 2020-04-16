namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    public class AndroidIntent : JavaObjectWrapper
    {
        private const string CLASS_NAME = "android.content.Intent";

        public AndroidIntent(AndroidJavaObject javaObject) : base(javaObject) { }

        public AndroidIntent(AndroidJavaClass activityClass) : base(CLASS_NAME, AndroidContext.GetActivityContext(), activityClass) { }

        public AndroidJavaObject Intent => JavaObject;

        public AndroidIntent PutExtra(string name, AndroidJavaObject value)
        {
            JavaObject = JavaObject.Call<AndroidJavaObject>("putExtra", name, value);
            return this;
        }

        public T GetExtra<T>(string name) => JavaObject.Call<T>("getExtra", name);
    }
}
