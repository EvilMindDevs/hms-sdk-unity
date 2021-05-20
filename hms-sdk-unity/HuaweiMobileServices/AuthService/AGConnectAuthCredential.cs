using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    public class AGConnectAuthCredential : JavaObjectWrapper
    {
        
        public AGConnectAuthCredential(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.auth.AGConnectAuthCredential");

        public static int Anonymous = javaClass.GetStatic<int>("Anonymous");
        public static int HMS_Provider = javaClass.GetStatic<int>("HMS_Provider");
        public static int Facebook_Provider = javaClass.GetStatic<int>("Facebook_Provider");
        public static int Twitter_Provider = javaClass.GetStatic<int>("Twitter_Provider");
        public static int WeiXin_Provider = javaClass.GetStatic<int>("WeiXin_Provider");
        public static int HWGame_Provider = javaClass.GetStatic<int>("HWGame_Provider");
        public static int QQ_Provider = javaClass.GetStatic<int>("QQ_Provider");
        public static int WeiBo_Provider = javaClass.GetStatic<int>("WeiBo_Provider");
        public static int Google_Provider = javaClass.GetStatic<int>("Google_Provider");
        public static int GoogleGame_Provider = javaClass.GetStatic<int>("GoogleGame_Provider");
        public static int SelfBuild_Provider = javaClass.GetStatic<int>("SelfBuild_Provider");
        public static int Phone_Provider = javaClass.GetStatic<int>("Phone_Provider");
        public static int Email_Provider = javaClass.GetStatic<int>("Email_Provider");

        public int GetProvider() => Call<int>("getProvider");

    }
}
