using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Message
{
    public class Policy : JavaObjectWrapper
    {
        public Policy() : base("com.huawei.hms.nearby.message.Policy") { }
        public Policy(AndroidJavaObject javaObject) : base(javaObject) { }

        public static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.message.Policy");
        public static Policy BLE_ONLY => androidJavaClass.GetStaticAsWrapper<Policy>("BLE_ONLY");
        public static Policy DEFAULT => androidJavaClass.GetStaticAsWrapper<Policy>("DEFAULT");       
        public static int POLICY_FINDING_MODE_BROADCAST => androidJavaClass.GetStatic<int>("POLICY_FINDING_MODE_BROADCAST");
        public static int POLICY_FINDING_MODE_SCAN => androidJavaClass.GetStatic<int>("POLICY_FINDING_MODE_SCAN");
        public static int POLICY_FINDING_MODE_DEFAULT => androidJavaClass.GetStatic<int>("POLICY_FINDING_MODE_DEFAULT");
        public static int POLICY_DISTANCE_TYPE_DEFAULT => androidJavaClass.GetStatic<int>("POLICY_DISTANCE_TYPE_DEFAULT"); 
        public static int POLICY_DISTANCE_TYPE_EARSHOT => androidJavaClass.GetStatic<int>("POLICY_DISTANCE_TYPE_EARSHOT"); 
        public static int POLICY_TTL_SECONDS_DEFAULT => androidJavaClass.GetStatic<int>("POLICY_TTL_SECONDS_DEFAULT"); 
        public static int POLICY_TTL_SECONDS_INFINITE => androidJavaClass.GetStatic<int>("POLICY_TTL_SECONDS_INFINITE"); 
        public static int POLICY_TTL_SECONDS_MAX => androidJavaClass.GetStatic<int>("POLICY_TTL_SECONDS_MAX");
        
    }
}
