using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Void = HuaweiMobileServices.Utils.Void;

namespace HuaweiMobileServices.Push
{
    public class HmsMessaging : JavaObjectWrapper
    {
        public HmsMessaging(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.push.HmsMessaging");
       
        public static string DEFAULT_TOKEN_SCOPE => androidJavaClass.GetStatic<String>("DEFAULT_TOKEN_SCOPE");
        public static HmsMessaging GetInstance()
        {
            return androidJavaClass.CallStaticAsWrapper<HmsMessaging>("getInstance", AndroidContext.ApplicationContext);   
        }
        public bool AutoInitEnabled => Call<bool>("isAutoInitEnabled");
        public void SetAutoInitEnabled(bool enable) => Call("setAutoInitEnabled", enable);
        public ITask<Void> Subscribe(String topic) => CallAsWrapper<TaskVoidWrapper>("subscribe", topic);
        public ITask<Void> UnSubscribe(String topic) => CallAsWrapper<TaskVoidWrapper>("unsubscribe", topic);
        public void Send(RemoteMessage message) => Call("send", message);
        public ITask<Void> TurnOnPush() => CallAsWrapper<TaskVoidWrapper>("turnOnPush");
        public ITask<Void> TurnOffPush() => CallAsWrapper<TaskVoidWrapper>("turnOnPush");

    }
}
