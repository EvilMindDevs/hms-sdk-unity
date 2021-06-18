using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.AppMessaging
{
    public class AppMessage : JavaObjectWrapper
    {
        public AppMessage(AndroidJavaObject javaObject) : base(javaObject) { }

        public long Id => Call<long>("getId");
        public MessageType MessageType => Call<MessageType>("getMessageType");
        public long StartTime => Call<long>("getStartTime");
        public long EndTime => Call<long>("getEndTime");
        public int FrequencyType => Call<int>("getFrequencyType");
        public int FrequencyValue => Call<int>("getFrequencyValue");
        public int TestFlag => Call<int>("getTestFlag");
        public List<string> TriggerEvents => Call<List<string>>("getTriggerEvents");
    }
}