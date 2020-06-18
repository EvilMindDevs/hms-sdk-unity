namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.games.AppPlayerInfo
    public class AppPlayerInfo : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public AppPlayerInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual string Rank
        {
            get => CallAsString("getRank");
        }

        public virtual string Role
        {
            get => CallAsString("getRole");
        }

        public virtual string Area
        {
            get => CallAsString("getArea");
        }

        public virtual string Sociaty
        {
            get => CallAsString("getSociaty");
        }

        public virtual string PlayerId
        {
            get => CallAsString("getPlayerId");
        }
    }

}