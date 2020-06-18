using System.Collections.Generic;

namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class EventsClientWrapper : JavaObjectWrapper, IEventsClient
    {
        [UnityEngine.Scripting.Preserve]
        public EventsClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public ITask<IList<Event>> GetEventList(bool paramBoolean)
        {
            var javaTask = Call<AndroidJavaObject>("getEventList", paramBoolean);
            return new TaskWrapper<IList<Event>>(javaTask, AndroidJavaObjectExtensions.AsListFromWrappable<Event>);
        }

        public ITask<IList<Event>> GetEventListByIds(bool paramBoolean, params string[] paramVarArgs)
        {
            var javaArgs = paramVarArgs.AsJavaArray(AndroidJavaObjectExtensions.AsJavaString);
            var javaTask = Call<AndroidJavaObject>("getEventListByIds", paramBoolean, javaArgs);
            return new TaskWrapper<IList<Event>>(javaTask, AndroidJavaObjectExtensions.AsListFromWrappable<Event>);
        }

        public void Grow(string aString, int aInt)
        {
            Call("grow", aString.AsJavaString(), aInt);
        }
    }
}
