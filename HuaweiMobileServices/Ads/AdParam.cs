using System.Collections.Generic;

namespace HuaweiMobileServices.Ads
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.ads.AdParam
    public class AdParam : JavaObjectWrapper
    {

        public AdParam(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual string TargetingContentUrl => CallAsString("getTargetingContentUrl");

        public int Gender => Call<int>("getGender");

        public ISet<string> Keywords => Call<AndroidJavaObject>("getKeywords").AsStringSet();

        public Location Code()
        {
            return this.Code_Conflict.B();
        }

        public RequestOptions V()
        {
            return this.Code_Conflict.C();
        }

        // Wrapper for com.huawei.hms.ads.AdParam.Builder
        public class Builder : JavaObjectWrapper
        {

            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }



            public Builder AddKeyword(string param1String)
            {
                this.Code.Code(Param1String);
                return this;
            }

            //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
            //ORIGINAL LINE: @GlobalApi public final AdParam build()
            public AdParam Build()
            {
                return new AdParam(this, (sbyte)0);
            }

            //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
            //ORIGINAL LINE: @GlobalApi public final Builder setTargetingContentUrl(String param1String)
            public Builder setTargetingContentUrl(string Param1String)
            {
                this.Code.V(Param1String);
                return this;
            }

            //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
            //ORIGINAL LINE: @GlobalApi public final Builder setGender(int param1Int)
            public Builder setGender(int Param1Int)
            {
                this.Code.Code(Param1Int);
                return this;
            }

            //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
            //ORIGINAL LINE: @GlobalApi public final Builder setRequestOrigin(String param1String)
            public Builder setRequestOrigin(string Param1String)
            {
                this.Code.I(Param1String);
                return this;
            }

            //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
            //ORIGINAL LINE: @GlobalApi public final Builder setBelongCountryCode(String param1String)
            public Builder setBelongCountryCode(string Param1String)
            {
                this.Code.S(Param1String);
                return this;
            }

            //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
            //ORIGINAL LINE: @GlobalApi public final Builder setTagForChildProtection(System.Nullable<int> param1Integer)
            public Builder setTagForChildProtection(int? Param1Integer)
            {
                this.Code.Code(Param1Integer.Value);
                return this;
            }

            //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
            //ORIGINAL LINE: @GlobalApi public final Builder setNonPersonalizedAd(System.Nullable<int> param1Integer)
            public Builder setNonPersonalizedAd(int? Param1Integer)
            {
                this.Code.V(Param1Integer);
                return this;
            }

            //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
            //ORIGINAL LINE: @GlobalApi public final Builder setAppLang(String param1String)
            public Builder setAppLang(string Param1String)
            {
                this.Code.Z(Param1String);
                return this;
            }

            //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
            //ORIGINAL LINE: @GlobalApi public final Builder setAppCountry(String param1String)
            public Builder setAppCountry(string Param1String)
            {
                this.Code.B(Param1String);
                return this;
            }

            //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
            //ORIGINAL LINE: @GlobalApi public final Builder setTagForUnderAgeOfPromise(System.Nullable<int> param1Integer)
            public Builder setTagForUnderAgeOfPromise(int? Param1Integer)
            {
                this.Code.I(Param1Integer);
                return this;
            }

            //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
            //ORIGINAL LINE: @GlobalApi public final Builder setAdContentClassification(String param1String)
            public Builder setAdContentClassification(string Param1String)
            {
                this.Code.C(Param1String);
                return this;
            }
        }

        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @GlobalApi public static interface ErrorCode
        public interface ErrorCode
        {
            public static int INNER = 0;

            public static int INVALID_REQUEST = 1;

            public static int NETWORK_ERROR = 2;

            public static int NO_AD = 3;

            public static int AD_LOADING = 4;

            public static int LOW_API = 5;

            public static int BANNER_AD_EXPIRE = 6;

            public static int BANNER_AD_CANCEL = 7;
        }
    }

}