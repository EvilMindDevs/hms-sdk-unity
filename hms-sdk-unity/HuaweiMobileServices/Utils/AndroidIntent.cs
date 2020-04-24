namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    public class AndroidIntent : JavaObjectWrapper
    {
        private const string CLASS_NAME = "android.content.Intent";

        public AndroidIntent(AndroidJavaObject javaObject) : base(javaObject) { }

        public AndroidIntent(AndroidJavaClass activityClass) : base(CLASS_NAME, AndroidContext.GetActivityContext(), activityClass) { }

        public AndroidJavaObject Intent => JavaObject;

        public int GetIntExtra<T>(string name) => JavaObject.Call<int>("getIntExtra", name, 1);
    }
}
