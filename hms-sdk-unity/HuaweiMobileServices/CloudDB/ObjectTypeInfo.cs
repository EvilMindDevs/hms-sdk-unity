using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.CloudDB
{
    public class ObjectTypeInfo : JavaObjectWrapper
    {
        public ObjectTypeInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        public long ObjectTypeVersion
        {
            get => Call<long>("getObjectTypeVersion"); 
            set => Call("setObjectTypeVersion", value);
        }

        public int FormatVersion
        {
            get => Call<int>("getFormatVersion"); 
            set => Call("setFormatVersion", value);
        }
    }

    public class ObjectTypeInfoHelper 
    {
        public static ObjectTypeInfo GetObjectTypeInfo(string path) 
            => new AndroidJavaClass(path).CallStaticAsWrapper<ObjectTypeInfo>("getObjectTypeInfo");
    }
}
