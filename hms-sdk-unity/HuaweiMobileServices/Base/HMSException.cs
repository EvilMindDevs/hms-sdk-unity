using System;

namespace HuaweiMobileServices.Base
{

    using UnityEngine;

    public class HMSException : Exception
    {
        internal HMSException(AndroidJavaObject javaObject) : base()
        {
            JavaException = javaObject;
        }

        internal AndroidJavaObject JavaException { get; }
    }

}
