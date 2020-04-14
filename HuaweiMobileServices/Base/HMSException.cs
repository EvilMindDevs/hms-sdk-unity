namespace HuaweiMobileServices.Base
{
    public class HMSException : System.Exception
    {
        internal HMSException() : base() { }
        internal HMSException(string message) : base(message) { }
        internal HMSException(int errorCode) : base(errorCode.ToString()) { }
    }
}
