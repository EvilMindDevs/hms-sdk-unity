using System;
using System.Collections.Generic;
using System.Text;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.AppLinking
{
    public class AppLinking : JavaObjectWrapper
    {
        public AppLinking(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.agconnect.applinking.AppLinking");


        public string GetUri => CallAsUriString("getUri");
        //public string GetResourceUri() => Call<string>("getResourceUri");

        // Wrapper for com.huawei.agconnect.applinking.AppLinking$Builder
        public class Builder : JavaObjectWrapper
        {

            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.agconnect.applinking.AppLinking$Builder") { }

            public AppLinking BuildAppLinking() => CallAsWrapper<AppLinking>("buildAppLinking");

        }

    }

}
