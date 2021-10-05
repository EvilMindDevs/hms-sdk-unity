using HuaweiMobileServices.Utils;
using UnityEngine;


namespace HuaweiMobileServices.Analystics
{
    public class HAEventType : JavaObjectWrapper
    {

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

        public static string ADDFRIEND => androidJavaClass.GetStatic<string>("ADDFRIEND");

        public static string ADDBLACKLIST => androidJavaClass.GetStatic<string>("ADDBLACKLIST");

        public static string VIEWFRIENDLIST => androidJavaClass.GetStatic<string>("VIEWFRIENDLIST");

        public static string QUITUSERGROUP => androidJavaClass.GetStatic<string>("QUITUSERGROUP");

        public static string CREATEUSERGROUP => androidJavaClass.GetStatic<string>("CREATEUSERGROUP");

        public static string DISBANDUSERGROUP => androidJavaClass.GetStatic<string>("DISBANDUSERGROUP");

        public static string UPGRADEUSERGROUP => androidJavaClass.GetStatic<string>("UPGRADEUSERGROUP");

        public static string VIEWUSERGROUP => androidJavaClass.GetStatic<string>("VIEWUSERGROUP");

        public static string JOINTEAM => androidJavaClass.GetStatic<string>("JOINTEAM");

        public static string SENDMESSAGE => androidJavaClass.GetStatic<string>("SENDMESSAGE");

        public static string LEARNSKILL => androidJavaClass.GetStatic<string>("LEARNSKILL");

        public static string USESKILL => androidJavaClass.GetStatic<string>("USESKILL");

        public static string GETEQUIPMENT => androidJavaClass.GetStatic<string>("GETEQUIPMENT");

        public static string LOSEEQUIPMENT => androidJavaClass.GetStatic<string>("LOSEEQUIPMENT");

        public static string ENHANCEEQUIPMENT => androidJavaClass.GetStatic<string>("ENHANCEEQUIPMENT");

        public static string SWITCHCLASS => androidJavaClass.GetStatic<string>("SWITCHCLASS");

        public static string ACCEPTTASK => androidJavaClass.GetStatic<string>("ACCEPTTASK");

        public static string FINISHTASK => androidJavaClass.GetStatic<string>("FINISHTASK");

        public static string ATTENDACTIVITY => androidJavaClass.GetStatic<string>("ATTENDACTIVITY");

        public static string FINISHCUTSCENE => androidJavaClass.GetStatic<string>("FINISHCUTSCENE");

        public static string SKIPCUTSCENE => androidJavaClass.GetStatic<string>("SKIPCUTSCENE");

        public static string GETPET => androidJavaClass.GetStatic<string>("GETPET");

        public static string LOSEPET => androidJavaClass.GetStatic<string>("LOSEPET");

        public static string ENHANCEPET => androidJavaClass.GetStatic<string>("ENHANCEPET");

        public static string GETMOUNT => androidJavaClass.GetStatic<string>("GETMOUNT");

        public static string LOSEMOUNT => androidJavaClass.GetStatic<string>("LOSEMOUNT");

        public static string ENHANCEMOUNT => androidJavaClass.GetStatic<string>("ENHANCEMOUNT");

        public static string CREATEROLE => androidJavaClass.GetStatic<string>("CREATEROLE");

        public static string SIGNINROLE => androidJavaClass.GetStatic<string>("SIGNINROLE");

        public static string SIGNOUTROLE => androidJavaClass.GetStatic<string>("SIGNOUTROLE");

        public static string STARTBATTLE => androidJavaClass.GetStatic<string>("STARTBATTLE");

        public static string ENDBATTLE => androidJavaClass.GetStatic<string>("ENDBATTLE");

        public static string STARTDUNGEON => androidJavaClass.GetStatic<string>("STARTDUNGEON");

        public static string FINISHDUNGEON => androidJavaClass.GetStatic<string>("FINISHDUNGEON");

        public static string VIEWPACKAGE => androidJavaClass.GetStatic<string>("VIEWPACKAGE");

        public static string REDEEM => androidJavaClass.GetStatic<string>("REDEEM");

        public static string MODIFYSETTING => androidJavaClass.GetStatic<string>("MODIFYSETTING");

        public static string WATCHVIDEO => androidJavaClass.GetStatic<string>("WATCHVIDEO");

        public static string CLICKMESSAGE => androidJavaClass.GetStatic<string>("CLICKMESSAGE");

        public static string DRAWCARD => androidJavaClass.GetStatic<string>("DRAWCARD");

        public static string VIEWCARDLIST => androidJavaClass.GetStatic<string>("VIEWCARDLIST");

        public static string BINDACCOUNT => androidJavaClass.GetStatic<string>("BINDACCOUNT");

        public static string STARTEXERCISE => androidJavaClass.GetStatic<string>("STARTEXERCISE");

        public static string ENDEXERCISE => androidJavaClass.GetStatic<string>("ENDEXERCISE");

        public static string STARTPLAYMEDIA => androidJavaClass.GetStatic<string>("STARTPLAYMEDIA");

        public static string ENDPLAYMEDIA => androidJavaClass.GetStatic<string>("ENDPLAYMEDIA");

        public static string STARTEXAMINE => androidJavaClass.GetStatic<string>("STARTEXAMINE");

        public static string ENDEXAMINE => androidJavaClass.GetStatic<string>("ENDEXAMINE");

        public static string CHECKIN => androidJavaClass.GetStatic<string>("CHECKIN");

        public static string COMPENSATION => androidJavaClass.GetStatic<string>("COMPENSATION");

        public static string POST => androidJavaClass.GetStatic<string>("POST");

        public static string SHAREAPP => androidJavaClass.GetStatic<string>("SHAREAPP");

        public static string IMPROVEINFORMATION => androidJavaClass.GetStatic<string>("IMPROVEINFORMATION");

    }
}
