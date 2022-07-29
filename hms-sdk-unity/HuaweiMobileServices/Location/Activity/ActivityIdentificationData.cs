using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Location
{
    public class ActivityIdentificationData : JavaObjectWrapper
    {
        public ActivityIdentificationData(AndroidJavaObject javaObject) : base(javaObject) { }
        
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.ActivityIdentificationData");

        public ActivityIdentificationData(int identificationActivity, int possibility) : base("com.huawei.hms.location.ActivityIdentificationData", identificationActivity, possibility) { }

        public static int VEHICLE = javaClass.GetStatic<int>("VEHICLE");
        public static int BIKE = javaClass.GetStatic<int>("BIKE");
        public static int FOOT = javaClass.GetStatic<int>("FOOT");
        public static int STILL = javaClass.GetStatic<int>("STILL");
        public static int OTHERS = javaClass.GetStatic<int>("OTHERS");
        public static int WALKING = javaClass.GetStatic<int>("WALKING");
        public static int RUNNING = javaClass.GetStatic<int>("RUNNING");

        public int GetIdentificationActivity() => Call<int>("getIdentificationActivity");

        public int GetPossibility() => Call<int>("getPossibility");

        public static bool IsValidType(int type) => javaClass.CallStatic<bool>("isValidType", type);

        public void SetIdentificationActivity(int identificationActivity) => Call("setIdentificationActivity", identificationActivity);

        public void SetPossibility(int possibility) => Call("setPossibility", possibility);

    }
}
