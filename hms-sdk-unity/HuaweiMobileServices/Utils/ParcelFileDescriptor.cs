using UnityEngine;
using System.Collections;

namespace HuaweiMobileServices.Utils
{
    public class ParcelFileDescriptor : JavaObjectWrapper
    {
        private const string CLASS_NAME = "android.os.Parcelable";

        public ParcelFileDescriptor(AndroidJavaObject javaObject) : base(javaObject) { }

        public ParcelFileDescriptor() : base(CLASS_NAME) { }

    }
}