namespace HuaweiMobileServices.Game
{
    using System;
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    internal class GameTrialProcessWrapper : AndroidJavaProxy
    {
        private Action mOnTrialTimeOut;

        private Action<bool> mOnCheckRealNameResult;

        public GameTrialProcessWrapper(Action onTrialTimeOut, Action<bool> onCheckRealNameResult) : base("com.huawei.hms.jos.games.player.GameTrialProcess")
        {
            mOnTrialTimeOut = onTrialTimeOut;
            mOnCheckRealNameResult = onCheckRealNameResult;
        }

        public void onTrialTimeOut()
        {
            this.CallOnMainThread(() => { mOnTrialTimeOut.Invoke(); });
        }

        public void onCheckRealNameResult(bool hasRealName)
        {
            this.CallOnMainThread(() => { mOnCheckRealNameResult.Invoke(hasRealName); });
        }
    }
}
