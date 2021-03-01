using UnityEngine;
using System.Collections;

namespace HuaweiMobileServices.Utils
{
    public class Parcel : JavaObjectWrapper
    {
        private const string CLASS_NAME = "android.os.Parcel";

        public Parcel(AndroidJavaObject javaObject) : base(javaObject) { }

        public Parcel() : base(CLASS_NAME) { }

    }
}