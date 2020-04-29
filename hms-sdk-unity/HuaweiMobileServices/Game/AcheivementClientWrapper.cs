using System;
using System.Collections.Generic;

namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class AcheivementClientWrapper : JavaObjectWrapper, IAchievementsClient
    {
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.auth.GameBridge");

        public AcheivementClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public void ShowAchievementList(Action onSuccess, Action<HMSException> onFailure)
        {
            var intent = Call<AndroidJavaObject>("getShowAchievementList");
            var callback = new GenericBridgeCallbackWrapper()
                .AddOnFailureListener(onFailure)
                .AddOnSuccessListener((nothing) =>
                {
                    onSuccess.Invoke();
                });
            sJavaClass.CallStatic("receiveShowAchievementList", intent, callback);
        }

        public ITask<IList<Achievement>> GetAchievementList(bool paramBoolean)
        {
            var javaTask = Call<AndroidJavaObject>("getAchievementList", paramBoolean);
            return new TaskWrapper<IList<Achievement>>(javaTask, AndroidJavaObjectExtensions.AsListFromWrappable<Achievement>);
        }

        public void Grow(string paramString, int paramInt) => Call("grow", paramString.AsJavaString(), paramInt);

        public ITask<bool> GrowWithResult(string paramString, int paramInt) =>
            CallAsWrapper<TaskPrimitive<bool>>("growWithResult", paramString.AsJavaString(), paramInt);

        public void MakeSteps(string paramString, int paramInt) => Call("makeSteps", paramString.AsJavaString(), paramInt);

        public ITask<bool> MakeStepsWithResult(string paramString, int paramInt) =>
            CallAsWrapper<TaskPrimitive<bool>>("makeStepsWithResult", paramString.AsJavaString(), paramInt);

        public void Reach(string paramString) => Call("reach", paramString.AsJavaString());

        public ITask<Void> ReachWithResult(string paramString) =>
            CallAsWrapper<TaskVoidWrapper>("reachWithResult", paramString.AsJavaString());

        public void Visualize(string paramString) => Call("visualize", paramString.AsJavaString());

        public ITask<Void> VisualizeWithResult(string paramString) =>
            CallAsWrapper<TaskVoidWrapper>("visualizeWithResult", paramString.AsJavaString());
    }
}
