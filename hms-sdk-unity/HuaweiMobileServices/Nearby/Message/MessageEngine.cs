using UnityEngine;
using System.Collections;
using HuaweiMobileServices.Utils;
using System.Threading.Tasks;
using System.Collections.Generic;
using HuaweiMobileServices.Base;

namespace HuaweiMobileServices.Nearby.Message
{
    public class MessageEngine : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public MessageEngine(AndroidJavaObject javaObject) : base(javaObject) { }
        public void HandleIntent(AndroidIntent intent, MessageHandler handler) => Call("handleIntent", intent, handler);
        public ITask<Void> Put(Message message) => CallAsWrapper<TaskVoidWrapper>("put", message);
        public ITask<Void> Put(Message message, PutOption option) => CallAsWrapper<TaskVoidWrapper>("put", message, option);
        public ITask<Void> RegisterStatusCallback(StatusCallback statusCallback) => CallAsWrapper<TaskVoidWrapper>("registerStatusCallback", statusCallback);
        public ITask<Void> Get(MessageHandler handler) => CallAsWrapper<TaskVoidWrapper>("get", handler);
        public ITask<Void> Get(MessageHandler handler, GetOption option) => CallAsWrapper<TaskVoidWrapper>("get", handler, option); 
        public ITask<Void> UnPut(Message message) => CallAsWrapper<TaskVoidWrapper>("unput", message);
        public ITask<Void> UnRegisterStatusCallback(StatusCallback statusCallback) => CallAsWrapper<TaskVoidWrapper>("unregisterStatusCallback", statusCallback);
        public ITask<Void> UnGet(MessageHandler handler) => CallAsWrapper<TaskVoidWrapper>("unget", handler);
 
    }
}
