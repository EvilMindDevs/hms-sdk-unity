namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Id;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.games.player.Player
    public class Player : JavaObjectWrapper
    {

        internal Player(AndroidJavaObject javaObject) : base(javaObject) { }

        public Player(string json, AuthHuaweiId authHuaweiId)
            : base("com.huawei.hms.jos.games.player.Player", json.AsJavaString(), authHuaweiId.JavaObject) { }

        public virtual string DisplayName
        {
            get => CallAsString("getDisplayName");
        }

        public virtual string HiResImageUri
        {
            get => CallAsUriString("getHiResImageUri");
        }

        public virtual string IconImageUri
        {
            get => CallAsUriString("getIconImageUri");
        }

        public virtual int Level
        {
            get => Call<int>("getLevel");
        }

        public virtual string PlayerId
        {
            get => CallAsString("getPlayerId");
        }

        public virtual bool HasHiResImage() => Call<bool>("hasHiResImage");

        public virtual bool HasIconImage() => Call<bool>("hasIconImage");

        public virtual string PlayerSign
        {
            get => CallAsString("getPlayerSign");
        }

        public virtual string SignTs
        {
            get => CallAsString("getSignTs");
        }
    }

}