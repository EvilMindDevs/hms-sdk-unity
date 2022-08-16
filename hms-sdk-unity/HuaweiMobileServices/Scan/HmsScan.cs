using HuaweiMobileServices.Utils;

using System.Collections.Generic;

using UnityEngine;

namespace HuaweiMobileServices.Scan
{
    public class HmsScan : JavaObjectWrapper
    {
        public HmsScan(AndroidJavaObject javaObject) : base(javaObject) { }
        public HmsScan() : base("com.huawei.hms.ml.scan.HmsScan") { }

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ml.scan.HmsScan");
        public static int ALL_SCAN_TYPE => sJavaClass.GetStatic<int>("ALL_SCAN_TYPE");
        public static int ARTICLE_NUMBER_FORM => sJavaClass.GetStatic<int>("ARTICLE_NUMBER_FORM");
        public static int AZTEC_SCAN_TYPE => sJavaClass.GetStatic<int>("AZTEC_SCAN_TYPE");
        public static int CODABAR_SCAN_TYPE => sJavaClass.GetStatic<int>("CODABAR_SCAN_TYPE");
        public static int CODE39_SCAN_TYPE => sJavaClass.GetStatic<int>("CODE39_SCAN_TYPE");
        public static int CODE93_SCAN_TYPE => sJavaClass.GetStatic<int>("CODE93_SCAN_TYPE");
        public static int CODE128_SCAN_TYPE => sJavaClass.GetStatic<int>("CODE128_SCAN_TYPE");
        public static int CONTACT_DETAIL_FORM => sJavaClass.GetStatic<int>("CONTACT_DETAIL_FORM");
        public static int DATAMATRIX_SCAN_TYPE => sJavaClass.GetStatic<int>("DATAMATRIX_SCAN_TYPE");
        public static int DRIVER_INFO_FORM => sJavaClass.GetStatic<int>("DRIVER_INFO_FORM");
        public static int EAN8_SCAN_TYPE => sJavaClass.GetStatic<int>("EAN8_SCAN_TYPE");
        public static int EAN13_SCAN_TYPE => sJavaClass.GetStatic<int>("EAN13_SCAN_TYPE");
        public static int EMAIL_CONTENT_FORM => sJavaClass.GetStatic<int>("EMAIL_CONTENT_FORM");
        public static int EVENT_INFO_FORM => sJavaClass.GetStatic<int>("EVENT_INFO_FORM");
        public static int FORMAT_UNKNOWN => sJavaClass.GetStatic<int>("FORMAT_UNKNOWN");
        public static int ISBN_NUMBER_FORM => sJavaClass.GetStatic<int>("ISBN_NUMBER_FORM");
        public static int ITF14_SCAN_TYPE => sJavaClass.GetStatic<int>("ITF14_SCAN_TYPE");
        public static int LOCATION_COORDINATE_FORM => sJavaClass.GetStatic<int>("LOCATION_COORDINATE_FORM");
        public static int OTHER_FORM => sJavaClass.GetStatic<int>("OTHER_FORM");
        public static int PDF417_SCAN_TYPE => sJavaClass.GetStatic<int>("PDF417_SCAN_TYPE");
        public static int PURE_TEXT_FORM => sJavaClass.GetStatic<int>("PURE_TEXT_FORM");
        public static int QRCODE_SCAN_TYPE => sJavaClass.GetStatic<int>("QRCODE_SCAN_TYPE");
        public static int SMS_FORM => sJavaClass.GetStatic<int>("SMS_FORM");
        public static int TEL_PHONE_NUMBER_FORM => sJavaClass.GetStatic<int>("TEL_PHONE_NUMBER_FORM");
        public static int UPCCODE_A_SCAN_TYPE => sJavaClass.GetStatic<int>("UPCCODE_A_SCAN_TYPE");
        public static int UPCCODE_E_SCAN_TYPE => sJavaClass.GetStatic<int>("UPCCODE_E_SCAN_TYPE");
        public static int URL_FORM => sJavaClass.GetStatic<int>("URL_FORM");
        public static int WIFI_CONNECT_INFO_FORM => sJavaClass.GetStatic<int>("WIFI_CONNECT_INFO_FORM");

        public Rect GetBorderRect => CallAsWrapper<Rect>("getBorderRect");
        public ContactDetail GetContactDetail => CallAsWrapper<ContactDetail>("getContactDetail");
        public Point[] GetCornerPoints => CallAsWrapperArray<Point>("getCornerPoints");
        public DriverInfo GetDriverInfo => CallAsWrapper<DriverInfo>("getDriverInfo");
        public EmailContent GetEmailContent => CallAsWrapper<EmailContent>("getEmailContent");
        public EventInfo GetEventInfo => CallAsWrapper<EventInfo>("getEventInfo");
        public LinkUrl GetLinkUrl => CallAsWrapper<LinkUrl>("getLinkUrl");
        public LinkUrl GetLocationCoordinate => CallAsWrapper<LinkUrl>("getLocationCoordinate");
        public Bitmap GetOriginalBitmap => CallAsWrapper<Bitmap>("getOriginalBitmap");
        public string GetOriginalValue => CallAsString("getOriginalValue");
        public byte[] GetOriginValueByte => Call<byte[]>("getOriginValueByte");
        public int GetScanType => Call<int>("getScanType");
        public int GetScanTypeForm => Call<int>("getScanTypeForm");
        public string GetShowResult => CallAsString("getShowResult");
        public SmsContent GetSmsContent => CallAsWrapper<SmsContent>("getSmsContent");
        public TelPhoneNumber GetTelPhoneNumber => CallAsWrapper<TelPhoneNumber>("getTelPhoneNumber");
        public WiFiConnectionInfo GetWifiConnectionInfo => CallAsWrapper<WiFiConnectionInfo>("getWiFiConnectionInfo");
        public double GetZoomValue => Call<double>("getZoomValue");
        public HmsScan SetZoomValue(double zoomValue) => CallAsWrapper<HmsScan>("setZoomValue", zoomValue);

        public class AddressInfo : JavaObjectWrapper
        {
            public AddressInfo(AndroidJavaObject javaObject) : base(javaObject) { }
            public AddressInfo() : base("com.huawei.hms.ml.scan.HmsScan$AddressInfo") { }

            private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ml.scan.HmsScan$AddressInfo");
            public static int OFFICE_TYPE => sJavaClass.GetStatic<int>("OFFICE_TYPE");
            public static int OTHER_USE_TYPE => sJavaClass.GetStatic<int>("OTHER_USE_TYPE");
            public static int RESIDENTIAL_USE_TYPE => sJavaClass.GetStatic<int>("RESIDENTIAL_USE_TYPE");
            public string[] GetAddressDetails => CallAsStringArray("getAddressDetails");
            public int GetAddressType => Call<int>("getAddressType");
        }

        public class ContactDetail : JavaObjectWrapper
        {
            public ContactDetail(AndroidJavaObject javaObject) : base(javaObject) { }
            public ContactDetail() : base("com.huawei.hms.ml.scan.HmsScan$ContactDetail") { }

            public IList<AddressInfo> GetAddressesInfos => CallAsWrapperList<AddressInfo>("getAddressesInfos");
            public string GetCompany => CallAsString("getCompany");
            public string[] GetContactLinks => CallAsStringArray("getContactLinks");
            public IList<EmailContent> GetEmailContents => CallAsWrapperList<EmailContent>("getEmailContents");
            public PeopleName GetPeopleName => CallAsWrapper<PeopleName>("getPeopleName");
            public IList<TelPhoneNumber> GetTelPhoneNumbers => CallAsWrapperList<TelPhoneNumber>("getTelPhoneNumbers");
            public string GetTitle => CallAsString("getTitle");
        }

        public class DriverInfo : JavaObjectWrapper
        {
            public DriverInfo(AndroidJavaObject javaObject) : base(javaObject) { }
            public DriverInfo() : base("com.huawei.hms.ml.scan.HmsScan$DriverInfo") { }

            public string GetAvenue => CallAsString("getAvenue");
            public string GetCertificateType => CallAsString("getCertificateType");
            public string GetCity => CallAsString("getCity");
            public string GetCountryOfIssue => CallAsString("getCountryOfIssue");
            public string GetCertificateNumber => CallAsString("getCertificateNumber");
            public string GetDateOfBirth => CallAsString("getDateOfBirth");
            public string GetDateOfExpire => CallAsString("getDateOfExpire");
            public string GetDateOfIssue => CallAsString("getDateOfIssue");
            public string GetFamilyName => CallAsString("getFamilyName");
            public string GetGivenName => CallAsString("getGivenName");
            public string GetMiddleName => CallAsString("getMiddleName");
            public string GetProvince => CallAsString("getProvince");
            public string GetSex => CallAsString("getSex");
            public string GetZipCode => CallAsString("getZipCode");
        }

        public class EmailContent : JavaObjectWrapper
        {
            public EmailContent(AndroidJavaObject javaObject) : base(javaObject) { }
            public EmailContent() : base("com.huawei.hms.ml.scan.HmsScan$EmailContent") { }

            private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ml.scan.HmsScan$EmailContent");
            public static int OFFICE_USE_TYPE => sJavaClass.GetStatic<int>("OFFICE_USE_TYPE");
            public static int OTHER_USE_TYPE => sJavaClass.GetStatic<int>("OTHER_USE_TYPE");
            public static int RESIDENTIAL_USE_TYPE => sJavaClass.GetStatic<int>("RESIDENTIAL_USE_TYPE");
            public string GetAddressInfo => CallAsString("getAddressInfo");
            public int GetAddressType => Call<int>("getAddressType");
            public string GetBodyInfo => CallAsString("getBodyInfo");
            public string GetSubjectInfo => CallAsString("getSubjectInfo");
        }

        public class EventInfo : JavaObjectWrapper
        {
            public EventInfo(AndroidJavaObject javaObject) : base(javaObject) { }
            public EventInfo() : base("com.huawei.hms.ml.scan.HmsScan$EventInfo") { }

            public string GetAbstractInfo => CallAsString("getAbstractInfo");
            public EventTime GetBeginTime => CallAsWrapper<EventTime>("getBeginTime");
            public EventTime GetCloseTime => CallAsWrapper<EventTime>("getCloseTime");
            public string GetCondition => CallAsString("getCondition");
            public string GetPlaceInfo => CallAsString("getPlaceInfo");
            public string GetSponsor => CallAsString("getSponsor");
            public string GetTheme => CallAsString("getTheme");

        }

        public class EventTime : JavaObjectWrapper
        {
            public EventTime(AndroidJavaObject javaObject) : base(javaObject) { }
            public EventTime() : base("com.huawei.hms.ml.scan.HmsScan$EventTime") { }

            public int GetDay => Call<int>("getDay");
            public int GetHours => Call<int>("getHours");
            public int GetMinutes => Call<int>("getMinutes");
            public int GetMonth => Call<int>("getMonth");
            public string GetOriginalValue => CallAsString("getOriginalValue");
            public int GetSeconds => Call<int>("getSeconds");
            public int GetYear => Call<int>("getYear");
            public bool IsUTCTime => Call<bool>("isUTCTime");
        }

        public class LinkUrl : JavaObjectWrapper
        {
            public LinkUrl(AndroidJavaObject javaObject) : base(javaObject) { }
            public LinkUrl() : base("com.huawei.hms.ml.scan.HmsScan$LinkUrl") { }

            public double GetLinkValue => Call<double>("getLinkValue");
            public double GetTheme => Call<double>("getTheme");
        }

        public class LocationCoordinate : JavaObjectWrapper
        {
            public LocationCoordinate(AndroidJavaObject javaObject) : base(javaObject) { }
            public LocationCoordinate() : base("com.huawei.hms.ml.scan.HmsScan$LocationCoordinate") { }

            public double GetLatitude => Call<double>("getLatitude");
            public double GetLongitude => Call<double>("getLongitude");
        }

        public class PeopleName : JavaObjectWrapper
        {
            public PeopleName(AndroidJavaObject javaObject) : base(javaObject) { }
            public PeopleName() : base("com.huawei.hms.ml.scan.HmsScan$PeopleName") { }

            public string GetFamilyName => CallAsString("getFamilyName");
            public string GetFullName => CallAsString("getFullName");
            public string GetSpelling => CallAsString("getSpelling");
            public string GetNameSuffix => CallAsString("getNameSuffix");
            public string GetNamePrefix => CallAsString("getNamePrefix");
            public string GetMiddleName => CallAsString("getMiddleName");
            public string GetGivenName => CallAsString("getGivenName");
        }

        public class SmsContent : JavaObjectWrapper
        {
            public SmsContent(AndroidJavaObject javaObject) : base(javaObject) { }
            public SmsContent() : base("com.huawei.hms.ml.scan.HmsScan$SmsContent") { }

            public string GetDestPhoneNumber => CallAsString("getDestPhoneNumber");
            public string GetMsgContent => CallAsString("getMsgContent");
        }

        public class TelPhoneNumber : JavaObjectWrapper
        {
            public TelPhoneNumber(AndroidJavaObject javaObject) : base(javaObject) { }
            public TelPhoneNumber() : base("com.huawei.hms.ml.scan.HmsScan$TelPhoneNumber") { }


            private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ml.scan.HmsScan$TelPhoneNumber");
            public static int CELLPHONE_NUMBER_USE_TYPE => sJavaClass.GetStatic<int>("CELLPHONE_NUMBER_USE_TYPE");
            public static int FAX_USE_TYPE => sJavaClass.GetStatic<int>("FAX_USE_TYPE");
            public static int OFFICE_USE_TYPE => sJavaClass.GetStatic<int>("OFFICE_USE_TYPE");
            public static int OTHER_USE_TYPE => sJavaClass.GetStatic<int>("OTHER_USE_TYPE");
            public static int RESIDENTIAL_USE_TYPE => sJavaClass.GetStatic<int>("RESIDENTIAL_USE_TYPE");
            public string GetTelPhoneNumber => CallAsString("getTelPhoneNumber");
            public int GetUseType => Call<int>("getUseType");
        }

        public class WiFiConnectionInfo : JavaObjectWrapper
        {
            public WiFiConnectionInfo(AndroidJavaObject javaObject) : base(javaObject) { }
            public WiFiConnectionInfo() : base("com.huawei.hms.ml.scan.HmsScan$WiFiConnectionInfo") { }


            private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ml.scan.HmsScan$WiFiConnectionInfo");
            public static int NO_PASSWORD_MODE_TYPE => sJavaClass.GetStatic<int>("NO_PASSWORD_MODE_TYPE");
            public static int WEP_MODE_TYPE => sJavaClass.GetStatic<int>("WEP_MODE_TYPE");
            public static int WPA_MODE_TYPE => sJavaClass.GetStatic<int>("WPA_MODE_TYPE");
            public static int SAE_MODE_TYPE => sJavaClass.GetStatic<int>("SAE_MODE_TYPE");
            public int GetCipherMode => Call<int>("getCipherMode");
            public string GetPassword => CallAsString("getPassword");
            public string GetSsidNumber => CallAsString("getSsidNumber");
        }
    }
}