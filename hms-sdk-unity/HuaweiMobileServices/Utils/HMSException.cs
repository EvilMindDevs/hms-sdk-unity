using System;

namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    public class HMSException : Exception
    {
        public HMSException(string message) : base(message) { WrappedCauseMessage = "Unknown"; WrappedExceptionMessage = "Unknown"; }

        public HMSException(string message, string causeMessage, string exceptionMessage) : base(message) { _causeMessage = causeMessage; _exceptionMessage = exceptionMessage; }

        internal HMSException(int errorCode) : base()
        {
            ErrorCode = errorCode;
        }

        internal HMSException(AndroidJavaObject javaObject) : base()
        {
            JavaException = javaObject;
        }

        private string _causeMessage;
        private string _exceptionMessage;

        internal AndroidJavaObject JavaException { get; }

        public int ErrorCode { get; }

        public string WrappedExceptionMessage
        {
            get
            {
                if (JavaException == null)
                    return _exceptionMessage;

                return JavaException.Call<AndroidJavaObject>("getMessage") != null ? JavaException.Call<AndroidJavaObject>("getMessage").AsString() : "Unknown";
            }
            private set { }
        }

        public string WrappedCauseMessage
        {
            get
            {
                if (JavaException == null)
                    return _causeMessage;

                var cause = JavaException.Call<AndroidJavaObject>("getCause");
                var message = JavaException.Call<AndroidJavaObject>("getMessage");
                if (cause != null)
                    return cause.AsString();
                if (message != null)
                    return message.AsString();

                return "Unknown";
            }
            private set { }
        }
    }
}
