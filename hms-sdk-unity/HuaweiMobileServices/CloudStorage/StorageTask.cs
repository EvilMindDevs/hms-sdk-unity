using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.CloudStorage
{
    public class StorageTask<TResult> : JavaObjectWrapper where TResult : StorageTask<TResult>.IErrorResult
    {
        public StorageTask(AndroidJavaObject javaObject) : base(javaObject) { }

        public StorageTask<TResult> AddOnSuccessListener(Action<TResult> action)
        {
            Debug.Log("[HMS StorageTask AddOnSuccessListener");

            return CallAsWrapper<StorageTask<TResult>>("addOnSuccessListener", new OnSuccessListener<TResult>(new SuccessListener<TResult>(action)).JavaProxy);
        }

        public StorageTask<TResult> AddOnFailureListener(Action<HMSException> OnFailureListener) => CallAsWrapper<StorageTask<TResult>>("addOnFailureListener", OnFailureListener);

        public bool Cancel() => CallAsBool("cancel");

        public bool IsCanceled() => CallAsBool("isCanceled");

        public bool IsComplete() => CallAsBool("isComplete");

        public bool IsSuccessful() => CallAsBool("isSuccessful");

        public bool IsInProgress() => CallAsBool("isInProgress");

        public bool IsPaused() => CallAsBool("isPaused");

        public bool Pause() => CallAsBool("pause");

        public bool Resume() => CallAsBool("resume");

        public TResult GetResult() => Call<TResult>("getResult");

        public void SetResult(TResult result) => Call("setResult", result);

        public TResult GetTimePointState() => Call<TResult>("getTimePointState");

        public Exception GetException() => Call<AndroidJavaObject>("getException").AsException();

        public void SetException(HMSException exception) => Call("getException", exception.AsJavaException());

        public class TimePointStateBase : JavaObjectWrapper, IErrorResult
        {
            public TimePointStateBase(AndroidJavaObject javaObject) : base(javaObject) { }

            public TimePointStateBase(Exception error) : base("com.huawei.agconnect.cloud.storage.core.StorageTask$ErrorResult", error) { }

            //private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.storage.core.StorageTask$TimePointStateBased");

            public StorageTask<TResult> GetTask() => CallAsWrapper<StorageTask<TResult>>("getTask");

            public StorageReference GetStorage() => CallAsWrapper<StorageReference>("getStorage");

            public Exception GetError() => getError().AsException();

            public AndroidJavaObject getError()
            {
                return Call<AndroidJavaObject>("getError");
            }
        }

        public interface IErrorResult
        {
            AndroidJavaObject getError();
        }

        internal class ErrorResult : AndroidJavaProxy
        {

            private readonly IErrorResult errorResult;

            public ErrorResult(IErrorResult errorResult) : base("com.huawei.agconnect.cloud.storage.core.StorageTask$ErrorResult")
            {
                this.errorResult = errorResult;
            }

            public Exception getError()
            {
                return errorResult.getError().AsException();
            }
        }

    }

    internal class SuccessListener<TResult> : IOnSuccessListener<TResult>
    {
        readonly Action<TResult> action;
        internal SuccessListener(Action<TResult> action) 
        {
            Debug.Log("[HMS StorageTask SuccessListener Constructor");
            this.action = action;
        }

        public void onSuccess(TResult var1)
        {
            Debug.Log("[HMS StorageTask SuccessListener onSuccess");
            action.Invoke(var1);
        }
    }
}
