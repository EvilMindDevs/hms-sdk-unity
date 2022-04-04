namespace HuaweiMobileServices.Ads
{
    using System;
    using static HuaweiMobileServices.Ads.Consent;
    using System.Collections.Generic;

    public interface IConsentUpdateListener
    {
        void OnFail(String desc);

        void OnSuccess(ConsentStatus consentStatus, bool isNeedConsent, List<AdProvider> adProviders);

    }
}