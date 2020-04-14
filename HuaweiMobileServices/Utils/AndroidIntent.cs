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
            JavaObject = JavaObject.Call<AndroidJavaObject>("putExtra", value);
            return this;
        }

    }
}
