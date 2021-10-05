
namespace HuaweiMobileServices.Analystics
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class HAParamType : JavaObjectWrapper
    {
        
        public HAParamType(AndroidJavaObject javaObject) : base(javaObject) { }

		private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.analytics.type.HAParamType");

		public static string ACHIEVEMENTID => androidJavaClass.GetStatic<string>("ACHIEVEMENTID");

		public static string STORENAME => androidJavaClass.GetStatic<string>("STORENAME");

		public static string ROLENAME => androidJavaClass.GetStatic<string>("ROLENAME");

		public static string OPTION => androidJavaClass.GetStatic<string>("OPTION");

		public static string STEP => androidJavaClass.GetStatic<string>("STEP");

		public static string CONTENTTYPE => androidJavaClass.GetStatic<string>("CONTENTTYPE");

		public static string VOUCHER => androidJavaClass.GetStatic<string>("VOUCHER");

		public static string CURRNAME => androidJavaClass.GetStatic<string>("CURRNAME");

		public static string DESTINATION => androidJavaClass.GetStatic<string>("DESTINATION");

		public static string ENDDATE => androidJavaClass.GetStatic<string>("ENDDATE");

		public static string FLIGHTNO => androidJavaClass.GetStatic<string>("FLIGHTNO");

		public static string BRAND => androidJavaClass.GetStatic<string>("BRAND");

		public static string USERGROUPID => androidJavaClass.GetStatic<string>("USERGROUPID");

		public static string POSITIONID => androidJavaClass.GetStatic<string>("POSITIONID");

		public static string CATEGORY => androidJavaClass.GetStatic<string>("CATEGORY");

		public static string PRODUCTID => androidJavaClass.GetStatic<string>("PRODUCTID");

		public static string PRODUCTNAME => androidJavaClass.GetStatic<string>("PRODUCTNAME");

		public static string PRODUCTFEATURE => androidJavaClass.GetStatic<string>("PRODUCTFEATURE");

		public static string PRICE => androidJavaClass.GetStatic<string>("PRICE");

		public static string QUANTITY => androidJavaClass.GetStatic<string>("QUANTITY");

		public static string REVENUE => androidJavaClass.GetStatic<string>("REVENUE");

		public static string PLACEID => androidJavaClass.GetStatic<string>("PLACEID");

		public static string BOOKINGDAYS => androidJavaClass.GetStatic<string>("BOOKINGDAYS");

		public static string PASSENGERSNUMBER => androidJavaClass.GetStatic<string>("PASSENGERSNUMBER");

		public static string BOOKINGROOMS => androidJavaClass.GetStatic<string>("BOOKINGROOMS");

		public static string ORIGINATINGPLACE => androidJavaClass.GetStatic<string>("ORIGINATINGPLACE");

		public static string BEGINDATE => androidJavaClass.GetStatic<string>("BEGINDATE");

		public static string TRANSACTIONID => androidJavaClass.GetStatic<string>("TRANSACTIONID");

		public static string CLASS => androidJavaClass.GetStatic<string>("CLASS");

		public static string CLICKID => androidJavaClass.GetStatic<string>("CLICKID");

		public static string PROMOTIONNAME => androidJavaClass.GetStatic<string>("PROMOTIONNAME");

		public static string CONTENT => androidJavaClass.GetStatic<string>("CONTENT");

		public static string EXTENDPARAM => androidJavaClass.GetStatic<string>("EXTENDPARAM");

		public static string MATERIALNAME => androidJavaClass.GetStatic<string>("MATERIALNAME");

		public static string MATERIALSLOT => androidJavaClass.GetStatic<string>("MATERIALSLOT");

		public static string MEDIUM => androidJavaClass.GetStatic<string>("MEDIUM");

		public static string SOURCE => androidJavaClass.GetStatic<string>("SOURCE");

		public static string KEYWORDS => androidJavaClass.GetStatic<string>("KEYWORDS");

		public static string VIRTUALCURRNAME => androidJavaClass.GetStatic<string>("VIRTUALCURRNAME");

		public static string PLACE => androidJavaClass.GetStatic<string>("PLACE");

		public static string SHIPPING => androidJavaClass.GetStatic<string>("SHIPPING");

		public static string TAXFEE => androidJavaClass.GetStatic<string>("TAXFEE");

		public static string LEVELNAME => androidJavaClass.GetStatic<string>("LEVELNAME");

		public static string RESULT => androidJavaClass.GetStatic<string>("RESULT");

		public static string LEVELID => androidJavaClass.GetStatic<string>("LEVELID");

		public static string CHANNEL => androidJavaClass.GetStatic<string>("CHANNEL");

		public static string SCORE => androidJavaClass.GetStatic<string>("SCORE");

		public static string SEARCHKEYWORDS => androidJavaClass.GetStatic<string>("SEARCHKEYWORDS");

		public static string PRODUCTLIST => androidJavaClass.GetStatic<string>("PRODUCTLIST");

		public static string ACOUNTTYPE => androidJavaClass.GetStatic<string>("ACOUNTTYPE");

		public static string OCCURREDTIME => androidJavaClass.GetStatic<string>("OCCURREDTIME");

		public static string EVTRESULT => androidJavaClass.GetStatic<string>("EVTRESULT");

		public static string PREVLEVEL => androidJavaClass.GetStatic<string>("PREVLEVEL");

		public static string CURRVLEVEL => androidJavaClass.GetStatic<string>("CURRVLEVEL");

		public static string VOUCHERS => androidJavaClass.GetStatic<string>("VOUCHERS");

		public static string MATERIALSLOTTYPE => androidJavaClass.GetStatic<string>("MATERIALSLOTTYPE");

		public static string LISTID => androidJavaClass.GetStatic<string>("LISTID");

		public static string FILTERS => androidJavaClass.GetStatic<string>("FILTERS");

		public static string SORTS => androidJavaClass.GetStatic<string>("SORTS");

		public static string ORDERID => androidJavaClass.GetStatic<string>("ORDERID");

		public static string PAYTYPE => androidJavaClass.GetStatic<string>("PAYTYPE");

		public static string REASON => androidJavaClass.GetStatic<string>("REASON");

		public static string EXPIREDATE => androidJavaClass.GetStatic<string>("EXPIREDATE");

		public static string VOUCHERTYPE => androidJavaClass.GetStatic<string>("VOUCHERTYPE");

		public static string SERVICETYPE => androidJavaClass.GetStatic<string>("SERVICETYPE");

		public static string DETAILS => androidJavaClass.GetStatic<string>("DETAILS");

		public static string COMMENTTYPE => androidJavaClass.GetStatic<string>("COMMENTTYPE");

		public static string REGISTMETHOD => androidJavaClass.GetStatic<string>("REGISTMETHOD");

		public static string DURATION => androidJavaClass.GetStatic<string>("DURATION");

		public static string LEVEL => androidJavaClass.GetStatic<string>("LEVEL");

		public static string PURCHASEENTRY => androidJavaClass.GetStatic<string>("PURCHASEENTRY");

		public static string PROPS => androidJavaClass.GetStatic<string>("PROPS");

		public static string ENTRY => androidJavaClass.GetStatic<string>("ENTRY");


	}
}
