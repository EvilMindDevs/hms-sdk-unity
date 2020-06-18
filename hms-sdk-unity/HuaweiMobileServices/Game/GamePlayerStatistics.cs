namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.games.playerstats.GamePlayerStatistics
    public sealed class GamePlayerStatistics : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public GamePlayerStatistics(AndroidJavaObject javaObject) : base(javaObject) { }

        public float AverageOnLineMinutes => Call<float>("getAverageOnLineMinutes");

        public int DaysFromLastGame => Call<int>("getDaysFromLastGame");

        public int PaymentTimes => Call<int>("getPaymentTimes");

        public int OnlineTimes => Call<int>("getOnlineTimes");

        public int TotalPurchasesAmountRange => Call<int>("getTotalPurchasesAmountRange");
    }

}