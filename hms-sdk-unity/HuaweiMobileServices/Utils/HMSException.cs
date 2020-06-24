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

        public string WrappedExceptionMessage => JavaException.Call<AndroidJavaObject>("getMessage").AsString();

        public string WrappedCauseMessage => JavaException
            .Call<AndroidJavaObject>("getCause")
            ?.Call<AndroidJavaObject>("getMessage")
            .AsString();
    }
}
