namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    public class AndroidIntent : JavaObjectWrapper
    {
        private const string CLASS_NAME = "android.content.Intent";

        [UnityEngine.Scripting.Preserve]
        public AndroidIntent(AndroidJavaObject javaObject) : base(javaObject) { }

        public AndroidIntent(AndroidJavaClass activityClass) : base(CLASS_NAME, AndroidContext.ActivityContext, activityClass) { }

        public AndroidJavaObject Intent => JavaObject;

        public int GetIntExtra<T>(string name) => Call<int>("getIntExtra", name, 1);
    }
}
