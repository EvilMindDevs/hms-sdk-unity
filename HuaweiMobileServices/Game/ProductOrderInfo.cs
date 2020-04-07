namespace com.huawei.hms.jos.product
{
    using HMSLog = com.huawei.hms.support.log.HMSLog;
    using JSONException = org.json.JSONException;
    using JSONObject = org.json.JSONObject;
    using Parcel = android.os.Parcel;
    using Parcelable = android.os.Parcelable;
    using TextUtils = android.text.TextUtils;

    public class ProductOrderInfo : Parcelable
    {
        private string a;

        private string b;

        private string c;

        private string d;

        public virtual string TradeId
        {
            get
            {
                return this.a;
            }
        }

        public virtual string ProductNo
        {
            get
            {
                return this.b;
            }
        }

        public virtual string OrderId
        {
            get
            {
                return this.c;
            }
        }

        public virtual string Sign
        {
            get
            {
                return this.d;
            }
        }

        public virtual int DescribeContents()
        {
            return 0;
        }

        internal ProductOrderInfo(string paramString)
        {
            if (TextUtils.isEmpty(paramString))
            {
                return;
            }
            try
            {
                JSONObject jSONObject = new JSONObject(paramString);
                this.a = jSONObject.optString("tradeId");
                this.b = jSONObject.optString("productNo");
                this.c = jSONObject.optString("orderId");
                this.d = jSONObject.optString("sign");
            }
            catch (JSONException)
            {
                HMSLog.e("ProductOrderInfo", "ProductOrderInfo from json meet excveption");
            }
        }

        public virtual void WriteToParcel(Parcel paramParcel, int paramInt)
        {
            paramParcel.writeString(this.a);
            paramParcel.writeString(this.b);
            paramParcel.writeString(this.c);
            paramParcel.writeString(this.d);
        }

        private ProductOrderInfo(Parcel paramParcel)
        {
            this.a = paramParcel.readString();
            this.b = paramParcel.readString();
            this.c = paramParcel.readString();
            this.d = paramParcel.readString();
        }

        public static readonly Parcelable.Creator<ProductOrderInfo> CREATOR = new object();
    }

}