using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.InAppComment
{
    /*public class OnInAppCommentListenerWrapper : AndroidJavaProxy
    {
        private readonly IOnInAppCommentListener callBack;

        internal OnInAppCommentListenerWrapper(IOnInAppCommentListener callBack) : base("org.m0skit0.android.hms.unity.inAppComment.OnInAppCommentCallBack")
        {
            this.callBack = callBack;
        }
        public void onInAppCommentResult()
        {
            callBack.onInAppCommentResult();
        }

        public interface IOnInAppCommentListener
        {
            void onInAppCommentResult();
        }
    }*/

    public class InAppCommentListenerWrapper : AndroidJavaProxy
    {
            private readonly Action<int> result;

            public InAppCommentListenerWrapper(Action<int> result) : base("org.m0skit0.android.hms.unity.inAppComment.InAppCommentListener")
            {
                this.result = result;
            }

            public void onInAppCommentResult(int code)
            {
                result?.Invoke(code);
            }
    }
}