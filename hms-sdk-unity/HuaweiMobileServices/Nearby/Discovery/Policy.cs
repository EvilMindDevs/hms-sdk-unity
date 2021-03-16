using HuaweiMobileServices.Utils;
using System;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Discovery
{
    public class Policy : JavaObjectWrapper
    {
        public Policy(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.discovery.Policy");
        public static Policy POLICY_MESH => androidJavaClass.GetStaticAsWrapper<Policy>("POLICY_MESH"); 
        public static Policy POLICY_P2P => androidJavaClass.GetStaticAsWrapper<Policy>("POLICY_P2P"); 
        public static Policy POLICY_STAR => androidJavaClass.GetStaticAsWrapper<Policy>("POLICY_STAR"); 
    }
}
