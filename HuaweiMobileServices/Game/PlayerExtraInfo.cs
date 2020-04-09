namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.games.player.PlayerExtraInfo
    public class PlayerExtraInfo : JavaObjectWrapper
    {

        public PlayerExtraInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        public PlayerExtraInfo(string json) : base("com.huawei.hms.jos.games.player.PlayerExtraInfo", json.AsJavaString()) { }

        public virtual bool IsAdult
        {
            get => Call<bool>("getIsAdult");
        }

        public virtual string PlayerId
        {
            get => CallAsString("getPlayerId");
        }

        public virtual int PlayerDuration
        {
            get => Call<int>("getPlayerDuration");
        }

        public virtual bool IsRealName
        {
            get => Call<bool>("getIsRealName");
        }
    }

}