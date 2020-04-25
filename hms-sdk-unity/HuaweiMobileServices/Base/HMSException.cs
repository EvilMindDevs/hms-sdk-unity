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

    public static class HMSExceptionUtils
    {
        public static HMSException AsHMSException(this AndroidJavaObject javaObject) =>
            new HMSException(javaObject);
    }

}
