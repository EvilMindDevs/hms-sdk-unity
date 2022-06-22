using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Location
{
    public class ActivityIdentificationData : JavaObjectWrapper
    {
        public ActivityIdentificationData(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.ActivityIdentificationData");

        public ActivityIdentificationData(int identificationActivity, int possibility) : base("com.huawei.hms.location.ActivityIdentificationData") { }

        //TODO Creator field

        public static int VEHICLE = 100;
        public static int BIKE = 101;
        public static int FOOT = 102;
        public static int STILL = 103;
        public static int OTHERS = 104;
        public static int WALKING = 107;
        public static int RUNNING = 108;

        public int GetIdentificationActivity()=> Call<int>("getIdentificationActivity");
        
        public int GetPossibility()=> Call<int>("getPossibility");

        public static bool IsValidType(int type) => javaClass.CallStatic<bool>("isValidType", type);

        public void SetIdentificationActivity(int identificationActivity) => Call("setIdentificationActivity", identificationActivity);

        public void SetPossibility(int possibility) => Call("setPossibility", possibility);


    }
}
