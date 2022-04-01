namespace HuaweiMobileServices.Ads
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;
    using System;
    using static HuaweiMobileServices.Ads.Consent;
    using System.Collections.Generic;

    public interface ConsentUpdateListener
    {
        void onFail(String desc);

        void onSuccess(ConsentStatus consentStatus, bool isNeedConsent, List<AdProvider> adProviders);

    }
}