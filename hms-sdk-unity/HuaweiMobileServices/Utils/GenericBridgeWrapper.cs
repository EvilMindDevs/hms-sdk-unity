using HuaweiMobileServices.Base;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Utils
{
    public class GenericBridgeWrapper : JavaObjectWrapper
    {
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.GenericBridge");


        public GenericBridgeWrapper(AndroidJavaObject javaObject): base(javaObject) { }
        
        protected internal override AndroidJavaObject JavaObject { get => base.JavaObject; set => base.JavaObject = value; }

        public void CallGenericBridge(Action onSuccess, Action<HMSException> onFailure, String methodName){

            CallAsWrapper<TaskAndroidJavaObject>(methodName)
                .AddOnSuccessListener((intent) =>
                {
                    var callback = new GenericBridgeCallbackWrapper()
                   .AddOnFailureListener(onFailure)
                   .AddOnSuccessListener((nothing) =>
                   {
                       onSuccess.Invoke();
                   });
                    sJavaClass.CallStatic("receiveShow", intent, callback);

                }).AddOnFailureListener((exception) => onFailure.Invoke(exception));
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
