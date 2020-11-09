namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Id;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.games.GameScopes
    public class GameScopes    
    {
        public static Scope DRIVE_APP_DATA = new Scope("https://www.huawei.com/auth/drive.appdata");
        public static Scope GAME_SERVICE_LITE = new Scope("https://www.huawei.com/game/services.lite");
        public static Scope CHECK_MOBILE_SCOPE = new Scope("https://www.huawei.com/auth/jos/checkmobile");
    }
}