namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.games.player.PlayerExtraInfo
    public class PlayerExtraInfo : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public PlayerExtraInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        public PlayerExtraInfo(string json) : base("com.huawei.hms.jos.games.player.PlayerExtraInfo", json.AsJavaString()) { }

        public virtual bool IsAdult => Call<bool>("getIsAdult");

        public virtual string PlayerId => CallAsString("getPlayerId");

        public virtual int PlayerDuration => Call<int>("getPlayerDuration");

        public virtual bool IsRealName => Call<bool>("getIsRealName");

    }

}