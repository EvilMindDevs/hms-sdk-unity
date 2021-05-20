using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Push
{
    public class HMSProfile : JavaObjectWrapper
    {
        public HMSProfile(AndroidJavaObject javaObject) : base(javaObject) { }
        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.push.HMSProfile");
        public static int HUAWEI_PROFILE => androidJavaClass.GetStatic<int>("HUAWEI_PROFILE");
        public static int CUSTOM_PROFILE => androidJavaClass.GetStatic<int>("CUSTOM_PROFILE");
        public static int UNDEFINED_PROFILE => androidJavaClass.GetStatic<int>("UNDEFINED_PROFILE");

        public static HMSProfile GetInstance()
        {
            return androidJavaClass.CallStaticAsWrapper<HMSProfile>("getInstance", AndroidContext.ApplicationContext);
        }
        public bool SupportProfile => Call<bool>("isSupportProfile");
        public bool AddProfile(int type, String profileId) => Call<bool>("addProfile", type, profileId);
        public bool AddProfile(String subjectId, int type, String profileId) => Call<bool>("addProfile", subjectId, type, profileId);
        public bool DeleteProfile(String profileId) => Call<bool>("deleteProfile", profileId);
        public bool DeleteProfile(String subjectId, String profileId) => Call<bool>("deleteProfile", subjectId, profileId);

    }
}
