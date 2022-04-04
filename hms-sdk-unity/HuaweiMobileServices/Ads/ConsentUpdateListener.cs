namespace HuaweiMobileServices.Ads
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;
    using System;
    using static HuaweiMobileServices.Ads.Consent;
    using System.Collections.Generic;

    public interface ConsentUpdateListener
    {
        void OnFail(String desc);

        void OnSuccess(ConsentStatus consentStatus, bool isNeedConsent, List<AdProvider> adProviders);

    }
}