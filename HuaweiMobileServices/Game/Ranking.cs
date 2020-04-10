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

        public static Ranking FromJson(string json) => sJavaClass.CallS

        public Ranking(Ranking paramRanking)
        {
            this.a = paramRanking.RankingId;
            this.b = paramRanking.RankingDisplayName;
            this.c = paramRanking.RankingImageUri;
            this.d = paramRanking.RankingScoreOrder;
            this.e = paramRanking.RankingVariants;
        }

        public Ranking()
        {
        }

        private string a;

        private string b;

        private Uri c;

        private int d;

        private List<IRankingVariant> e;

        public const int SCORE_VALUE_HIGH_BETTER = 1;

        public const int SCORE_VALUE_SMALL_BETTER = 0;

        public virtual string RankingDisplayName
        {
            get
            {
                return this.b;
            }
        }

        public virtual Uri RankingImageUri
        {
            get
            {
                return this.c;
            }
        }

        public virtual string RankingId
        {
            get
            {
                return this.a;
            }
        }

        public virtual int RankingScoreOrder
        {
            get
            {
                return this.d;
            }
        }

        public virtual List<IRankingVariant> RankingVariants
        {
            get
            {
                return this.e;
            }
        }
    }

}