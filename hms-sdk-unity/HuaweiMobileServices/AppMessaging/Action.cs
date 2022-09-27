
using HuaweiMobileServices.Utils;

using UnityEngine;

namespace HuaweiMobileServices.AppMessaging
{
    public class Action : JavaObjectWrapper
    {
        public Action(AndroidJavaObject javaObject) : base(javaObject) { }

        public string GetMessageTitle => CallAsString("getMessageTitle");
        public string GetActionUrl => CallAsString("getActionUrl");
        public ActionType GetActionType => CallAsWrapper<ActionType>("getActionType");

    }
}