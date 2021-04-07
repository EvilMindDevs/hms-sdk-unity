using HuaweiMobileServices.Utils;
using UnityEngine;


namespace HuaweiMobileServices.Analystics
{
    public class HAEventType : JavaObjectWrapper
	{
		[UnityEngine.Scripting.Preserve]
		public HAEventType(AndroidJavaObject javaObject) : base(javaObject) { }

		private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.analytics.type.HAEventType");

		public static string CREATEPAYMENTINFO => androidJavaClass.GetStatic<string>("CREATEPAYMENTINFO");

		public static string ADDPRODUCT2CART => androidJavaClass.GetStatic<string>("ADDPRODUCT2CART"); 
		public static string ADDPRODUCT2WISHLIST => androidJavaClass.GetStatic<string>("ADDPRODUCT2WISHLIST");

		public static string STARTAPP => androidJavaClass.GetStatic<string>("STARTAPP");

		public static string STARTCHECKOUT => androidJavaClass.GetStatic<string>("STARTCHECKOUT");

		public static string VIEWCAMPAIGN => androidJavaClass.GetStatic<string>("VIEWCAMPAIGN");

		public static string VIEWCHECKOUTSTEP => androidJavaClass.GetStatic<string>("VIEWCHECKOUTSTEP");

		public static string WINVIRTUALCOIN => androidJavaClass.GetStatic<string>("WINVIRTUALCOIN");

		public static string COMPLETEPURCHASE => androidJavaClass.GetStatic<string>("COMPLETEPURCHASE");

		public static string OBTAINLEADS => androidJavaClass.GetStatic<string>("OBTAINLEADS");

		public static string JOINUSERGROUP => androidJavaClass.GetStatic<string>("JOINUSERGROUP");

		public static string COMPLETELEVEL => androidJavaClass.GetStatic<string>("COMPLETELEVEL");

		public static string STARTLEVEL => androidJavaClass.GetStatic<string>("STARTLEVEL");

		public static string UPGRADELEVEL => androidJavaClass.GetStatic<string>("UPGRADELEVEL");

		public static string SIGNIN => androidJavaClass.GetStatic<string>("SIGNIN");

		public static string SIGNOUT => androidJavaClass.GetStatic<string>("SIGNOUT");

		public static string SUBMITSCORE => androidJavaClass.GetStatic<string>("SUBMITSCORE");

		public static string CREATEORDER => androidJavaClass.GetStatic<string>("CREATEORDER");

		public static string REFUNDORDER => androidJavaClass.GetStatic<string>("REFUNDORDER");

		public static string DELPRODUCTFROMCART => androidJavaClass.GetStatic<string>("DELPRODUCTFROMCART");

		public static string SEARCH => androidJavaClass.GetStatic<string>("SEARCH");

		public static string VIEWCONTENT => androidJavaClass.GetStatic<string>("VIEWCONTENT");

		public static string UPDATECHECKOUTOPTION => androidJavaClass.GetStatic<string>("UPDATECHECKOUTOPTION");

		public static string SHARECONTENT => androidJavaClass.GetStatic<string>("SHARECONTENT");

		public static string REGISTERACCOUNT => androidJavaClass.GetStatic<string>("REGISTERACCOUNT");

		public static string CONSUMEVIRTUALCOIN => androidJavaClass.GetStatic<string>("CONSUMEVIRTUALCOIN");

		public static string STARTTUTORIAL => androidJavaClass.GetStatic<string>("STARTTUTORIAL");

		public static string COMPLETETUTORIAL => androidJavaClass.GetStatic<string>("COMPLETETUTORIAL");

		public static string OBTAINACHIEVEMENT => androidJavaClass.GetStatic<string>("OBTAINACHIEVEMENT");

		public static string VIEWPRODUCT => androidJavaClass.GetStatic<string>("VIEWPRODUCT");

		public static string VIEWPRODUCTLIST => androidJavaClass.GetStatic<string>("VIEWPRODUCTLIST");

		public static string VIEWSEARCHRESULT => androidJavaClass.GetStatic<string>("VIEWSEARCHRESULT");

		public static string UPDATEMEMBERSHIPLEVEL => androidJavaClass.GetStatic<string>("UPDATEMEMBERSHIPLEVEL");

		public static string FILTRATEPRODUCT => androidJavaClass.GetStatic<string>("FILTRATEPRODUCT");

		public static string VIEWCATEGORY => androidJavaClass.GetStatic<string>("VIEWCATEGORY");

		public static string UPDATEORDER => androidJavaClass.GetStatic<string>("UPDATEORDER");

		public static string CANCELORDER => androidJavaClass.GetStatic<string>("CANCELORDER");

		public static string COMPLETEORDER => androidJavaClass.GetStatic<string>("COMPLETEORDER");

		public static string CANCELCHECKOUT => androidJavaClass.GetStatic<string>("CANCELCHECKOUT");

		public static string OBTAINVOUCHER => androidJavaClass.GetStatic<string>("OBTAINVOUCHER");

		public static string CONTACTCUSTOMSERVICE => androidJavaClass.GetStatic<string>("CONTACTCUSTOMSERVICE");

		public static string RATE => androidJavaClass.GetStatic<string>("RATE");

		public static string INVITE => androidJavaClass.GetStatic<string>("INVITE");

		public static string NOVICEGUIDESTART => androidJavaClass.GetStatic<string>("NOVICEGUIDESTART");

		public static string NOVICEGUIDEEND => androidJavaClass.GetStatic<string>("NOVICEGUIDEEND");

		public static string STARTGAME => androidJavaClass.GetStatic<string>("STARTGAME");

		public static string ENDGAME => androidJavaClass.GetStatic<string>("ENDGAME");

		public static string WINPROPS => androidJavaClass.GetStatic<string>("WINPROPS");

		public static string CONSUMEPROPS => androidJavaClass.GetStatic<string>("CONSUMEPROPS");

	}
}
