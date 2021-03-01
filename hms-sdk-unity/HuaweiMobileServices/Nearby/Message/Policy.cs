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
        public static Policy BLE_ONLY
        {
            get => androidJavaClass.GetStaticAsWrapper<Policy>("BLE_ONLY");
        }
        public static Policy DEFAULT
        {
            get => androidJavaClass.GetStaticAsWrapper<Policy>("DEFAULT");
        }
        public static int POLICY_FINDING_MODE_BROADCAST
        {
            get => androidJavaClass.GetStatic<int>("POLICY_FINDING_MODE_BROADCAST");
        }
        public static int POLICY_FINDING_MODE_SCAN
        {
            get => androidJavaClass.GetStatic<int>("POLICY_FINDING_MODE_SCAN");
        }
        public static int POLICY_FINDING_MODE_DEFAULT
        {
            get => androidJavaClass.GetStatic<int>("POLICY_FINDING_MODE_DEFAULT");
        }
        public static int POLICY_DISTANCE_TYPE_DEFAULT
        {
            get => androidJavaClass.GetStatic<int>("POLICY_DISTANCE_TYPE_DEFAULT");
        }
        public static int POLICY_DISTANCE_TYPE_EARSHOT
        {
            get => androidJavaClass.GetStatic<int>("POLICY_DISTANCE_TYPE_EARSHOT");
        }
        public static int POLICY_TTL_SECONDS_DEFAULT
        {
            get => androidJavaClass.GetStatic<int>("POLICY_TTL_SECONDS_DEFAULT");
        }
        public static int POLICY_TTL_SECONDS_INFINITE
        {
            get => androidJavaClass.GetStatic<int>("POLICY_TTL_SECONDS_INFINITE");
        }
        public static int POLICY_TTL_SECONDS_MAX
        {
            get => androidJavaClass.GetStatic<int>("POLICY_TTL_SECONDS_MAX");
        }

    }
}
