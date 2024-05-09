namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.iap.entity.ProductInfo
    public class ProductInfo : JavaObjectWrapper
    {
        private string productId { get; set;}
        private PriceType priceType { get; set;}
        private string price { get; set;}
        private long microsPrice { get; set; }
        private long originalMicroPrice { get; set; }
        private string originalLocalPrice { get; set; }
        private string currency { get; set; }
        private string productName { get; set; }
        private string productDesc { get; set; }
        private string subPeriod { get; set; }   
        private string subSpecialPrice { get; set; }     
        private long subSpecialPriceMicros { get; set; }
        private string subSpecialPeriod { get; set; }
        private int subSpecialPeriodCycles { get; set; }
        private string subFreeTrialPeriod { get; set; }
        private string subGroupId { get; set; }
        private string subGroupTitle { get; set; }
        private int subProductLevel { get; set; }
        private int status { get; set; }
        private int offerUsedStatus { get; set; }
        
        public ProductInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        public string ProductId {
            get {
                if (string.IsNullOrWhiteSpace(productId)) {
                    productId = Call<string>("getProductId");
                }
                return productId;
            }
        }
        public PriceType PriceType  {
            get {
                if (priceType == null) {
                    priceType = new PriceType(Call<int>("getPriceType"));
                }
                return priceType;
            }
        }
        public string Price {
            get {
                if (string.IsNullOrWhiteSpace(price)) {
                    price = Call<string>("getPrice");
                }
                return price;
            }
        }
        public long MicrosPrice {
            get {
                if (microsPrice == 0) {
                    microsPrice = Call<long>("getMicrosPrice");
                }
                return microsPrice;
            }
        }
        public string OriginalLocalPrice {
            get {
                if (string.IsNullOrWhiteSpace(originalLocalPrice)) {
                    originalLocalPrice = Call<string>("getOriginalLocalPrice");
                }
                return originalLocalPrice;
            }
        }
        public long OriginalMicroPrice {
            get {
                if (originalMicroPrice == 0) {
                    originalMicroPrice = Call<long>("getOriginalMicroPrice");
                }
                return originalMicroPrice;
            }
        }
        public string Currency {
            get {
                if (string.IsNullOrWhiteSpace(currency)) {
                    currency = Call<string>("getCurrency");
                }
                return currency;
            }
        }
        public string ProductName {
            get {
                if (string.IsNullOrWhiteSpace(productName)) {
                    productName = Call<string>("getProductName");
                }
                return productName;
            }
        }
        public string ProductDesc {
            get {
                if (string.IsNullOrEmpty(productDesc)) {
                    productDesc = Call<string>("getProductDesc");
                }
                return productDesc;
            }
        }
        public string SubPeriod {
            get {
                if (string.IsNullOrWhiteSpace(subPeriod)){
                    subPeriod = Call<string>("getSubPeriod");
                }
                return subPeriod;
            }
        }
        public string SubSpecialPrice {
            get {
                if (string.IsNullOrWhiteSpace(subSpecialPrice)) {
                    subSpecialPrice = Call<string>("getSubSpecialPrice");
                }
                return subSpecialPrice;
            }
        }
        public long SubSpecialPriceMicros {
            get {
                if (subSpecialPriceMicros == 0) {
                    subSpecialPriceMicros = Call<long>("getSubSpecialPriceMicros");
                }
                return subSpecialPriceMicros;
            }
        }
        public string SubSpecialPeriod {
            get {
                if (string.IsNullOrWhiteSpace(subSpecialPeriod)) {
                    subSpecialPeriod = Call<string>("getSubSpecialPeriod");
                }
                return subSpecialPeriod;
            }
        }
        public int SubSpecialPeriodCycles {
            get {
                if (subSpecialPeriodCycles == 0) {
                    subSpecialPeriodCycles = Call<int>("getSubSpecialPeriodCycles");
                }
                return subSpecialPeriodCycles;
            }
        }
        public string SubFreeTrialPeriod {
            get {
                if (string.IsNullOrWhiteSpace(subFreeTrialPeriod)) {
                    subFreeTrialPeriod = Call<string>("getSubFreeTrialPeriod");
                }
                return subFreeTrialPeriod;
            }
        }
        public string SubGroupId {
            get {
                if (string.IsNullOrWhiteSpace(subGroupId)) {
                    subGroupId = Call<string>("getSubGroupId");
                }
                return subGroupId;
            }
        }
        public string SubGroupTitle {
            get {
                if (string.IsNullOrWhiteSpace(subGroupTitle)) {
                    subGroupTitle = Call<string>("getSubGroupTitle");
                }
                return subGroupTitle;
            }
        }
        public int SubProductLevel {
            get {
                if (subProductLevel == 0) {
                    subProductLevel = Call<int>("getSubProductLevel");
                }
                return subProductLevel;
            }
        }
        public int Status {
            get {
                if (status == 0) {
                    status = Call<int>("getStatus");
                }
                return status;
            }
        }
        public int OfferUsedStatus {
            get {
                if (offerUsedStatus == 0) {
                    offerUsedStatus = Call<int>("getOfferUsedStatus");
                }
                return offerUsedStatus;
            }

            set {
                offerUsedStatus = value;
            }
        }

    }

}