
using UnityEngine;

namespace HuaweiMobileServices.Utils
{
  public  class UUID : JavaObjectWrapper
    {
        private const string CLASS_NAME = "java.util.UUID";

        public UUID(AndroidJavaObject javaObject) : base(javaObject) { }

        public UUID() : base(CLASS_NAME) { }
    }
}
