using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.IAP
{
    /// <summary>
    /// Base class for request objects.
    /// </summary>
    public abstract class BaseReq : JavaObjectWrapper
    {
        /// <summary>
        /// Constructor that wraps an existing AndroidJavaObject.
        /// </summary>
        /// <param name="javaObject">The AndroidJavaObject to wrap.</param>
        public BaseReq(AndroidJavaObject javaObject) : base(javaObject)
        {
        }

        /// <summary>
        /// Constructor that creates a new AndroidJavaObject.
        /// </summary>
        /// <param name="javaObjectCanonicalName">The canonical name of the Java object to create.</param>
        public BaseReq(string javaObjectCanonicalName) : base(javaObjectCanonicalName) { }

        /// <summary>
        /// Gets or sets the reserved information.
        /// </summary>
        public virtual string ReservedInfor
        {
            get => CallAsString("getReservedInfor");
            set => Call("setReservedInfor", value.AsJavaString());
        }
    }
}