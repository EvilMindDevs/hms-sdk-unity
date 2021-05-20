namespace HuaweiMobileServices.Game
{
    using System;
    using UnityEngine;

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
            mOnTrialTimeOut.Invoke();
        }

        public void onCheckRealNameResult(bool hasRealName)
        {
            mOnCheckRealNameResult.Invoke(hasRealName);
        }
    }
}
