using System.Collections.Generic;

namespace HuaweiMobileServices.Game
{

    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.games.RankingsClient.RankingScores
    public class RankingScores : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public static RankingScores NewInstance(AndroidJavaObject javaObject) => new RankingScores(javaObject);

        public RankingScores(AndroidJavaObject javaObject) : base(javaObject) { }

        public Ranking Ranking => CallAsWrapper<Ranking>("getRanking");

        public IList<RankingScore> RankingScore => CallAsWrapperList<RankingScore>("getRankingScore");

    }
}
