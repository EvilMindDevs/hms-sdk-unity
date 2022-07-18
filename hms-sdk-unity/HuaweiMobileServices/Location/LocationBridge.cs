﻿using HuaweiMobileServices.Location.Location;
using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Location
{
    public class LocationBridge : JavaObjectWrapper
    {
        public LocationBridge(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.location.LocationBridge");

        public static void GetLocationResult() => javaClass.CallStatic("getLocationResult");


    }
}
