using System.Collections.Generic;

namespace HuaweiMobileServices.Game
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.jos.games.ranking.Ranking
    public class Ranking : JavaObjectWrapper
    {

        private const string CLASS_NAME = "com.huawei.hms.jos.games.ranking.Ranking";

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

        public const int SCORE_VALUE_HIGH_BETTER = 1;

        public const int SCORE_VALUE_SMALL_BETTER = 0;

        public Ranking(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual string RankingDisplayName
        {
            get => CallAsString("getRankingDisplayName");
        }

        public virtual string RankingImageUri
        {
            get => CallAsUriString("getRankingImageUri");
        }

        public virtual string RankingId
        {
            get => CallAsString("getRankingId");
        }

        public virtual int RankingScoreOrder
        {
            get => Call<int>("getRankingScoreOrder");
        }

        public virtual IList<RankingVariant> RankingVariants
        {
            get => Call<AndroidJavaObject>("getRankingVariants").AsListFromWrappable<RankingVariant>();
        }
    }

}