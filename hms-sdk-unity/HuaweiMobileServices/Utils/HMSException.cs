using System;

namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    public class HMSException : Exception
    {

        public HMSException(string message) : base(message) { }

        internal HMSException(int errorCode) : base()
        {
            ErrorCode = errorCode;
        }

        internal HMSException(AndroidJavaObject javaObject) : base()
        {
            JavaException = javaObject;
        }

        internal AndroidJavaObject JavaException { get; }

        public int ErrorCode { get; }
    }

    public static class HMSExceptionUtils
    {
        public static HMSException AsHMSException(this AndroidJavaObject javaObject) =>
            new HMSException(javaObject);
    }

}
