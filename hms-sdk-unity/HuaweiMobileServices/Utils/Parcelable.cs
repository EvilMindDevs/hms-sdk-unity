using UnityEngine;
using System.Collections;

namespace HuaweiMobileServices.Utils
{
    public class Parcelable : JavaObjectWrapper
    {
        private const string CLASS_NAME = "android.os.Parcelable";

        public Parcelable(AndroidJavaObject javaObject) : base(javaObject) { }

        public Parcelable() : base(CLASS_NAME) { }

    }
}