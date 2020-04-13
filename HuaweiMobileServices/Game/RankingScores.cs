using System.Collections.Generic;

namespace HuaweiMobileServices.Game
{

    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.games.RankingsClient.RankingScores
    public class RankingScores : JavaObjectWrapper
    {

        public RankingScores(AndroidJavaObject javaObject) : base(javaObject) { }

        public Ranking Ranking
        {
            get => CallAsWrapper<Ranking>("getRanking");
        }

        public IList<RankingScore> RankingScore
        {
            get => CallAsWrapperList<RankingScore>("getRankingScore");
        }
    }
}
