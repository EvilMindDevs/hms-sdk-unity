using UnityEngine;
using System.Collections;
using HuaweiMobileServices.Utils;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HuaweiMobileServices.Nearby.Message
{
    public class MessageEngine : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public MessageEngine(AndroidJavaObject javaObject) : base(javaObject) { }
        public static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.message.MessageEngine");

        public void HandleIntent(AndroidJavaObject intent, MessageHandler handler) => androidJavaClass.Call("handleIntent", intent, handler);

        public Task<Void> Put(Message message) => androidJavaClass.Call<Task<Void>>("put", message);
        public Task<Void> Put(Message message, PutOption option) => androidJavaClass.Call<Task<Void>>("put", message, option);
        public Task<Void> RegisterStatusCallback(StatusCallback statusCallback) => androidJavaClass.Call<Task<Void>>("registerStatusCallback", statusCallback);
        public Task<Void> Get(MessageHandler handler) => androidJavaClass.Call<Task<Void>>("get", handler);
        public Task<Void> Get(MessageHandler handler, GetOption option) => androidJavaClass.Call<Task<Void>>("get", handler, option);
        //public Task<Void> Get(PendingIntent pendingIntent, GetOption option) => androidJavaClass.Call<Task<Void>>("put", handler);
        // public Task<Void> Get(PendingIntent pendingIntent, GetOption option, GetOption option) => androidJavaClass.Call<Task<Void>>("put", handler, option);
        public Task<Void> UnPut(Message message) => androidJavaClass.Call<Task<Void>>("unput", message);
        public Task<Void> UnRegisterStatusCallback(StatusCallback statusCallback) => androidJavaClass.Call<Task<Void>>("unregisterStatusCallback", statusCallback);
        public Task<Void> UnGet(MessageHandler handler) => androidJavaClass.Call<Task<Void>>("unget", handler);
        //public Task<Void> Get(PendingIntent pendingIntent, GetOption option) => androidJavaClass.Call<Task<Void>>("put", handler, option);

    }
}
