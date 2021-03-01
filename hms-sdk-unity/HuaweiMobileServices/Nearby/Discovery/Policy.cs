using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Discovery
{
    public class Policy : JavaObjectWrapper
    {
        public Policy() : base ("com.huawei.hms.nearby.discovery.Policy") { }
        public Policy(AndroidJavaObject javaObject) : base(javaObject) { }

        public static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.discovery.Policy");
        public static Policy POLICY_MESH
        {
            get => androidJavaClass.GetStaticAsWrapper<Policy>("POLICY_MESH");
        }
        public static Policy POLICY_P2P
        {
            get => androidJavaClass.GetStaticAsWrapper<Policy>("POLICY_P2P");
        }
        public static Policy POLICY_STAR
        {
            get => androidJavaClass.GetStaticAsWrapper<Policy>("POLICY_STAR");
        }
        //    public static final Parcelable.Creator<Policy> CREATOR;

    }
}
