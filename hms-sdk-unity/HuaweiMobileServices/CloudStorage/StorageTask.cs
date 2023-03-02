using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;

using System;

using UnityEngine;

namespace HuaweiMobileServices.CloudStorage
{
    public class StorageTask<TResult> : JavaObjectWrapper where TResult : StorageTask<TResult>.IErrorResult
    {
        public StorageTask(AndroidJavaObject javaObject) : base(javaObject) { }

        public StorageTask<TResult> AddOnSuccessListener(Action<AndroidJavaObject> action)
        {
            return CallAsWrapper<StorageTask<TResult>>("addOnSuccessListener", new OnSuccessListener<TResult>(new SuccessListener<TResult>(action)));
        }

        public StorageTask<TResult> AddOnFailureListener(Action<HMSException> action)
        {
            return CallAsWrapper<StorageTask<TResult>>("addOnFailureListener", new OnFailureListener(new FailureListener(action)));
        }

        public StorageTask<TResult> AddOnCompleteListener(Action<AndroidJavaObject> action)
        {
            return CallAsWrapper<StorageTask<TResult>>("addOnCompleteListener", new OnCompleteListener<TResult>(new CompleteListener<TResult>(action)));
        }

        public StorageTask<TResult> AddOnProgressListener(Action<AndroidJavaObject> action)
        {
            return CallAsWrapper<StorageTask<TResult>>("addOnProgressListener", new OnProgressListener<TResult>(new ProgressListener<TResult>(action)));
        }

        public StorageTask<TResult> AddOnPausedListener(Action<AndroidJavaObject> action)
        {
            return CallAsWrapper<StorageTask<TResult>>("addOnPausedListener", new OnPausedListener<TResult>(new PausedListener<TResult>(action)));
        }

        public StorageTask<TResult> AddOnCanceledListener(Action action)
        {
            return CallAsWrapper<StorageTask<TResult>>("addOnCanceledListener", new OnCanceledListener(new CanceledListener(action)));
        }

        public bool Cancel() => Call<bool>("cancel");

        public bool IsCanceled() => CallAsBool("isCanceled");

        public bool IsComplete() => CallAsBool("isComplete");

        public bool IsSuccessful() => CallAsBool("isSuccessful");

        public bool IsInProgress() => CallAsBool("isInProgress");

        public bool IsPaused() => CallAsBool("isPaused");

        public void Pause() => Call<bool>("pause");

        public bool Resume() => Call<bool>("resume");

        public TResult GetResult() => Call<TResult>("getResult");

        public void SetResult(TResult result) => Call("setResult", result);

        public TResult GetTimePointState() => Call<TResult>("getTimePointState");

        public Exception GetException() => Call<AndroidJavaObject>("getException").AsException();

        public void SetException(HMSException exception) => Call("getException", exception.AsJavaException());

        public class TimePointStateBase : JavaObjectWrapper, IErrorResult
        {
            public TimePointStateBase(AndroidJavaObject javaObject) : base(javaObject) { }

            public TimePointStateBase(Exception error) : base("com.huawei.agconnect.cloud.storage.core.StorageTask$ErrorResult", error) { }

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

    public class SuccessListener<TResult> : IOnSuccessListener<TResult>
    {
        readonly Action<AndroidJavaObject> action;
        internal SuccessListener(Action<AndroidJavaObject> action)
        {
            this.action = action;
        }

        public void onSuccess(AndroidJavaObject result)
        {
            action.Invoke(result);
        }
    }

    public class ProgressListener<TResult> : IOnProgressListener<TResult>
    {
        readonly Action<AndroidJavaObject> action;
        internal ProgressListener(Action<AndroidJavaObject> action)
        {
            this.action = action;
        }

        public void onProgress(AndroidJavaObject result)
        {
            action.Invoke(result);
        }

    }

    public class CompleteListener<TResult> : IOnCompleteListener<TResult>
    {
        readonly Action<AndroidJavaObject> action;
        internal CompleteListener(Action<AndroidJavaObject> action)
        {
            this.action = action;
        }

        public void onComplete(AndroidJavaObject result)
        {
            action.Invoke(result);
        }

    }

    public class PausedListener<TResult> : IOnPausedListener<TResult>
    {
        readonly Action<AndroidJavaObject> action;
        internal PausedListener(Action<AndroidJavaObject> action)
        {
            this.action = action;
        }

        public void onPaused(AndroidJavaObject result)
        {
            action.Invoke(result);
        }
    }

    public class CanceledListener : IOnCanceledListener
    {
        readonly Action action;
        internal CanceledListener(Action action)
        {
            this.action = action;
        }

        public void onCanceled()
        {
            action.Invoke();
        }
    }


    internal class FailureListener : IOnFailureListener
    {
        readonly Action<HMSException> action;
        internal FailureListener(Action<HMSException> action)
        {
            this.action = action;
        }

        public void onFailure(AndroidJavaObject javaException)
        {
            action.Invoke(javaException.AsException());
        }
    }

}
