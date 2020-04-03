using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Base
{
    public class JavaObjectWrapperByConstructor
    {
        internal protected readonly AndroidJavaObject mJavaObject;

        internal protected JavaObjectWrapperByConstructor(AndroidJavaObject javaObject)
        {
            mJavaObject = javaObject;
        }
    }
}
