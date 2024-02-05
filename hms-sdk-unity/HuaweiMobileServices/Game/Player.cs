namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Id;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.games.player.Player
    public class Player : JavaObjectWrapper
    {
        public Player(AndroidJavaObject javaObject) : base(javaObject) { }

        public Player(string json, AuthHuaweiId authHuaweiId)
            : base("com.huawei.hms.jos.games.player.Player", json.AsJavaString(), authHuaweiId.JavaObject) { }

        public virtual string DisplayName => CallAsString("getDisplayName");

        public virtual string HiResImageUri => CallAsUriString("getHiResImageUri");

        public virtual string IconImageUri => CallAsUriString("getIconImageUri");

        public virtual int Level => Call<int>("getLevel");

        [System.Obsolete("The PlayerId field will be deprecated in the future. It is recommended that you use OpenId instead of PlayerId to uniquely identify a player in a game.")]
        public virtual string PlayerId => CallAsString("getPlayerId");

        public virtual bool HasHiResImage() => Call<bool>("hasHiResImage");

        public virtual bool HasIconImage() => Call<bool>("hasIconImage");

        public virtual string PlayerSign => CallAsString("getPlayerSign");

        public virtual string SignTs => CallAsString("getSignTs");

        public virtual string OpenId => CallAsString("getOpenId");

        public virtual string UnionId => CallAsString("getUnionId");

        public virtual string AccessToken => CallAsString("getAccessToken");

        public virtual string OpenIdSign => CallAsString("getOpenIdSign");
    }

}