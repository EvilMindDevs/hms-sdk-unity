
namespace HuaweiMobileServices.Analystics
{
    using HuaweiMobileServices.Utils;

    using UnityEngine;


    public class HAParamType : JavaObjectWrapper
    {
        
        public HAParamType(AndroidJavaObject javaObject) : base(javaObject) { }

		private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.analytics.type.HAParamType");		public static string ACHIEVEMENTID => androidJavaClass.GetStatic<string>("ACHIEVEMENTID");		public static string STORENAME => androidJavaClass.GetStatic<string>("STORENAME");		public static string ROLENAME => androidJavaClass.GetStatic<string>("ROLENAME");		public static string OPTION => androidJavaClass.GetStatic<string>("OPTION");		public static string STEP => androidJavaClass.GetStatic<string>("STEP");		public static string CONTENTTYPE => androidJavaClass.GetStatic<string>("CONTENTTYPE");		public static string VOUCHER => androidJavaClass.GetStatic<string>("VOUCHER");		public static string CURRNAME => androidJavaClass.GetStatic<string>("CURRNAME");		public static string DESTINATION => androidJavaClass.GetStatic<string>("DESTINATION");		public static string ENDDATE => androidJavaClass.GetStatic<string>("ENDDATE");		public static string FLIGHTNO => androidJavaClass.GetStatic<string>("FLIGHTNO");		public static string BRAND => androidJavaClass.GetStatic<string>("BRAND");		public static string USERGROUPID => androidJavaClass.GetStatic<string>("USERGROUPID");		public static string POSITIONID => androidJavaClass.GetStatic<string>("POSITIONID");		public static string CATEGORY => androidJavaClass.GetStatic<string>("CATEGORY");		public static string PRODUCTID => androidJavaClass.GetStatic<string>("PRODUCTID");		public static string PRODUCTNAME => androidJavaClass.GetStatic<string>("PRODUCTNAME");		public static string PRODUCTFEATURE => androidJavaClass.GetStatic<string>("PRODUCTFEATURE");		public static string PRICE => androidJavaClass.GetStatic<string>("PRICE");		public static string QUANTITY => androidJavaClass.GetStatic<string>("QUANTITY");		public static string REVENUE => androidJavaClass.GetStatic<string>("REVENUE");		public static string PLACEID => androidJavaClass.GetStatic<string>("PLACEID");		public static string BOOKINGDAYS => androidJavaClass.GetStatic<string>("BOOKINGDAYS");		public static string PASSENGERSNUMBER => androidJavaClass.GetStatic<string>("PASSENGERSNUMBER");		public static string BOOKINGROOMS => androidJavaClass.GetStatic<string>("BOOKINGROOMS");		public static string ORIGINATINGPLACE => androidJavaClass.GetStatic<string>("ORIGINATINGPLACE");		public static string BEGINDATE => androidJavaClass.GetStatic<string>("BEGINDATE");		public static string TRANSACTIONID => androidJavaClass.GetStatic<string>("TRANSACTIONID");		public static string CLASS => androidJavaClass.GetStatic<string>("CLASS");		public static string CLICKID => androidJavaClass.GetStatic<string>("CLICKID");		public static string PROMOTIONNAME => androidJavaClass.GetStatic<string>("PROMOTIONNAME");		public static string CONTENT => androidJavaClass.GetStatic<string>("CONTENT");		public static string EXTENDPARAM => androidJavaClass.GetStatic<string>("EXTENDPARAM");		public static string MATERIALNAME => androidJavaClass.GetStatic<string>("MATERIALNAME");		public static string MATERIALSLOT => androidJavaClass.GetStatic<string>("MATERIALSLOT");		public static string MEDIUM => androidJavaClass.GetStatic<string>("MEDIUM");		public static string SOURCE => androidJavaClass.GetStatic<string>("SOURCE");		public static string KEYWORDS => androidJavaClass.GetStatic<string>("KEYWORDS");		public static string VIRTUALCURRNAME => androidJavaClass.GetStatic<string>("VIRTUALCURRNAME");		public static string PLACE => androidJavaClass.GetStatic<string>("PLACE");		public static string SHIPPING => androidJavaClass.GetStatic<string>("SHIPPING");		public static string TAXFEE => androidJavaClass.GetStatic<string>("TAXFEE");		public static string LEVELNAME => androidJavaClass.GetStatic<string>("LEVELNAME");		public static string RESULT => androidJavaClass.GetStatic<string>("RESULT");		public static string LEVELID => androidJavaClass.GetStatic<string>("LEVELID");		public static string CHANNEL => androidJavaClass.GetStatic<string>("CHANNEL");		public static string SCORE => androidJavaClass.GetStatic<string>("SCORE");		public static string SEARCHKEYWORDS => androidJavaClass.GetStatic<string>("SEARCHKEYWORDS");		public static string PRODUCTLIST => androidJavaClass.GetStatic<string>("PRODUCTLIST");		public static string ACOUNTTYPE => androidJavaClass.GetStatic<string>("ACOUNTTYPE");		public static string OCCURREDDATE => androidJavaClass.GetStatic<string>("OCCURREDDATE");		public static string EVTRESULT => androidJavaClass.GetStatic<string>("EVTRESULT");		public static string PREVLEVEL => androidJavaClass.GetStatic<string>("PREVLEVEL");		public static string CURRVLEVEL => androidJavaClass.GetStatic<string>("CURRVLEVEL");		public static string VOUCHERS => androidJavaClass.GetStatic<string>("VOUCHERS");		public static string MATERIALSLOTTYPE => androidJavaClass.GetStatic<string>("MATERIALSLOTTYPE");		public static string LISTID => androidJavaClass.GetStatic<string>("LISTID");		public static string FILTERS => androidJavaClass.GetStatic<string>("FILTERS");		public static string SORTS => androidJavaClass.GetStatic<string>("SORTS");		public static string ORDERID => androidJavaClass.GetStatic<string>("ORDERID");		public static string PAYTYPE => androidJavaClass.GetStatic<string>("PAYTYPE");		public static string REASON => androidJavaClass.GetStatic<string>("REASON");		public static string EXPIREDATE => androidJavaClass.GetStatic<string>("EXPIREDATE");		public static string VOUCHERTYPE => androidJavaClass.GetStatic<string>("VOUCHERTYPE");		public static string SERVICETYPE => androidJavaClass.GetStatic<string>("SERVICETYPE");		public static string DETAILS => androidJavaClass.GetStatic<string>("DETAILS");		public static string COMMENTTYPE => androidJavaClass.GetStatic<string>("COMMENTTYPE");		public static string REGISTMETHOD => androidJavaClass.GetStatic<string>("REGISTMETHOD");		public static string DURATION => androidJavaClass.GetStatic<string>("DURATION");		public static string LEVEL => androidJavaClass.GetStatic<string>("LEVEL");		public static string PURCHASEENTRY => androidJavaClass.GetStatic<string>("PURCHASEENTRY");		public static string PROPS => androidJavaClass.GetStatic<string>("PROPS");		public static string ENTRY => androidJavaClass.GetStatic<string>("ENTRY");          public static string INVITER => androidJavaClass.GetStatic<string>("INVITER");
        public static string VIPLEVEL => androidJavaClass.GetStatic<string>("VIPLEVEL");
        public static string FIRSTSIGNIN => androidJavaClass.GetStatic<string>("FIRSTSIGNIN");
        public static string DISCOUNT => androidJavaClass.GetStatic<string>("DISCOUNT");
        public static string FIRSTPAY => androidJavaClass.GetStatic<string>("FIRSTPAY");
        public static string TASKID => androidJavaClass.GetStatic<string>("TASKID");
        public static string FRIENDNUMBER => androidJavaClass.GetStatic<string>("FRIENDNUMBER");
        public static string USERGROUPNAME => androidJavaClass.GetStatic<string>("USERGROUPNAME");
        public static string USERGROUPLEVEL => androidJavaClass.GetStatic<string>("USERGROUPLEVEL");
        public static string MEMBERS => androidJavaClass.GetStatic<string>("MEMBERS");
        public static string LEVELBEFORE => androidJavaClass.GetStatic<string>("LEVELBEFORE");
        public static string MESSAGETYPE => androidJavaClass.GetStatic<string>("MESSAGETYPE");
        public static string ROLECOMBAT => androidJavaClass.GetStatic<string>("ROLECOMBAT");
        public static string ISTOPLEVEL => androidJavaClass.GetStatic<string>("ISTOPLEVEL");
        public static string ROLECLASS => androidJavaClass.GetStatic<string>("ROLECLASS");
        public static string SKILLNAME => androidJavaClass.GetStatic<string>("SKILLNAME");
        public static string SKILLLEVEL => androidJavaClass.GetStatic<string>("SKILLLEVEL");
        public static string SKILLLEVELBEFORE => androidJavaClass.GetStatic<string>("SKILLLEVELBEFORE");
        public static string EQUIPMENTID => androidJavaClass.GetStatic<string>("EQUIPMENTID");
        public static string EQUIPMENTNAME => androidJavaClass.GetStatic<string>("EQUIPMENTNAME");
        public static string EQUIPMENTLEVEL => androidJavaClass.GetStatic<string>("EQUIPMENTLEVEL");
        public static string CLASSLIMIT => androidJavaClass.GetStatic<string>("CLASSLIMIT");
        public static string LEVELLIMIT => androidJavaClass.GetStatic<string>("LEVELLIMIT");
        public static string ISFREE => androidJavaClass.GetStatic<string>("ISFREE");
        public static string TOTALAFTERCHANGE => androidJavaClass.GetStatic<string>("TOTALAFTERCHANGE");
        public static string QUALITY => androidJavaClass.GetStatic<string>("QUALITY");
        public static string ENHANCETYPE => androidJavaClass.GetStatic<string>("ENHANCETYPE");
        public static string NEWCLASS => androidJavaClass.GetStatic<string>("NEWCLASS");
        public static string OLDCLASS => androidJavaClass.GetStatic<string>("OLDCLASS");
        public static string TASKTYPE => androidJavaClass.GetStatic<string>("TASKTYPE");
        public static string TASKNAME => androidJavaClass.GetStatic<string>("TASKNAME");
        public static string REWARD => androidJavaClass.GetStatic<string>("REWARD");
        public static string ACTIVITYTYPE => androidJavaClass.GetStatic<string>("ACTIVITYTYPE");
        public static string ACTIVITYNAME => androidJavaClass.GetStatic<string>("ACTIVITYNAME");
        public static string CUTSCENENAME => androidJavaClass.GetStatic<string>("CUTSCENENAME");
        public static string PETID => androidJavaClass.GetStatic<string>("PETID");
        public static string PETDEFAULTNAME => androidJavaClass.GetStatic<string>("PETDEFAULTNAME");
        public static string PETLEVEL => androidJavaClass.GetStatic<string>("PETLEVEL");
        public static string MOUNTID => androidJavaClass.GetStatic<string>("MOUNTID");
        public static string MOUNTDEFAULTNAME => androidJavaClass.GetStatic<string>("MOUNTDEFAULTNAME");
        public static string MOUNTLEVEL => androidJavaClass.GetStatic<string>("MOUNTLEVEL");
        public static string ROLEGENDER => androidJavaClass.GetStatic<string>("ROLEGENDER");
        public static string SERVER => androidJavaClass.GetStatic<string>("SERVER");
        public static string FIRSTCREATE => androidJavaClass.GetStatic<string>("FIRSTCREATE");
        public static string COMBAT => androidJavaClass.GetStatic<string>("COMBAT");
        public static string BATTLETYPE => androidJavaClass.GetStatic<string>("BATTLETYPE");
        public static string BATTLENAME => androidJavaClass.GetStatic<string>("BATTLENAME");
        public static string NUMBEROFCARDS => androidJavaClass.GetStatic<string>("NUMBEROFCARDS");
        public static string CARDLIST => androidJavaClass.GetStatic<string>("CARDLIST");
        public static string PARTICIPANTS => androidJavaClass.GetStatic<string>("PARTICIPANTS");
        public static string DIFFICULTY => androidJavaClass.GetStatic<string>("DIFFICULTY");
        public static string MVP => androidJavaClass.GetStatic<string>("MVP");
        public static string DAMAGE => androidJavaClass.GetStatic<string>("DAMAGE");
        public static string RANKING => androidJavaClass.GetStatic<string>("RANKING");
        public static string DUNGEONNAME => androidJavaClass.GetStatic<string>("DUNGEONNAME");
        public static string WINREASON => androidJavaClass.GetStatic<string>("WINREASON");
        public static string BALANCE => androidJavaClass.GetStatic<string>("BALANCE");
        public static string PACKAGETYPE => androidJavaClass.GetStatic<string>("PACKAGETYPE");
        public static string AMOUNT => androidJavaClass.GetStatic<string>("AMOUNT");
        public static string ITEMLIST => androidJavaClass.GetStatic<string>("ITEMLIST");
        public static string GIFTTYPE => androidJavaClass.GetStatic<string>("GIFTTYPE");
        public static string GIFTNAME => androidJavaClass.GetStatic<string>("GIFTNAME");
        public static string TYPE => androidJavaClass.GetStatic<string>("TYPE");
        public static string OLDVALUE => androidJavaClass.GetStatic<string>("OLDVALUE");
        public static string NEWVALUE => androidJavaClass.GetStatic<string>("NEWVALUE");
        public static string VIDEOTYPE => androidJavaClass.GetStatic<string>("VIDEOTYPE");
        public static string VIDEONAME => androidJavaClass.GetStatic<string>("VIDEONAME");
        public static string MESSAGETITLE => androidJavaClass.GetStatic<string>("MESSAGETITLE");
        public static string OPERATION => androidJavaClass.GetStatic<string>("OPERATION");
        public static string NUMBEROFDRAWING => androidJavaClass.GetStatic<string>("NUMBEROFDRAWING");
        public static string LEFTPULLSFORGUARANTEE => androidJavaClass.GetStatic<string>("LEFTPULLSFORGUARANTEE");
        public static string VIPTYPE => androidJavaClass.GetStatic<string>("VIPTYPE");
        public static string VIPSTATUS => androidJavaClass.GetStatic<string>("VIPSTATUS");
        public static string VIPEXPIREDATE => androidJavaClass.GetStatic<string>("VIPEXPIREDATE");
        public static string ENTER => androidJavaClass.GetStatic<string>("ENTER");
        public static string STARTDATE => androidJavaClass.GetStatic<string>("STARTDATE");
        public static string EFFECTIVETIME => androidJavaClass.GetStatic<string>("EFFECTIVETIME");
        public static string NAME => androidJavaClass.GetStatic<string>("NAME");
        public static string MODE => androidJavaClass.GetStatic<string>("MODE");
        public static string SUBJECT => androidJavaClass.GetStatic<string>("SUBJECT");
        public static string ACCURACY => androidJavaClass.GetStatic<string>("ACCURACY");
        public static string CONTENTLENGTH => androidJavaClass.GetStatic<string>("CONTENTLENGTH");
        public static string REMARK => androidJavaClass.GetStatic<string>("REMARK");
        public static string CONTENTNAME => androidJavaClass.GetStatic<string>("CONTENTNAME");
        public static string SECTION => androidJavaClass.GetStatic<string>("SECTION");
        public static string DAYS => androidJavaClass.GetStatic<string>("DAYS");
        public static string POSTID => androidJavaClass.GetStatic<string>("POSTID");
        public static string INFORMATIONTYPE => androidJavaClass.GetStatic<string>("INFORMATIONTYPE");
        public static string INFORMATION => androidJavaClass.GetStatic<string>("INFORMATION");
        public static string FEATURE => androidJavaClass.GetStatic<string>("FEATURE");
        public static string ROOMS => androidJavaClass.GetStatic<string>("ROOMS");
        public static string SALEPRICE => androidJavaClass.GetStatic<string>("SALEPRICE");
        public static string RENTFEE => androidJavaClass.GetStatic<string>("RENTFEE");
        public static string RENTTYPE => androidJavaClass.GetStatic<string>("RENTTYPE");
        public static string PAGENAME => androidJavaClass.GetStatic<string>("PAGENAME");
        public static string SERIES => androidJavaClass.GetStatic<string>("SERIES");
        public static string MODEL => androidJavaClass.GetStatic<string>("MODEL");
        public static string DEVICETYPE => androidJavaClass.GetStatic<string>("DEVICETYPE");
        public static string DEVICENAME => androidJavaClass.GetStatic<string>("DEVICENAME");
        public static string BINDDURATION => androidJavaClass.GetStatic<string>("BINDDURATION");
        public static string DEALERNAME => androidJavaClass.GetStatic<string>("DEALERNAME");
        public static string ARRIVALDATE => androidJavaClass.GetStatic<string>("ARRIVALDATE");
        public static string BUYERTYPE => androidJavaClass.GetStatic<string>("BUYERTYPE");
        public static string SEAT => androidJavaClass.GetStatic<string>("SEAT");
        public static string ENERGY => androidJavaClass.GetStatic<string>("ENERGY");
        public static string CONFIGURATION => androidJavaClass.GetStatic<string>("CONFIGURATION");
        public static string ISLOAN => androidJavaClass.GetStatic<string>("ISLOAN");
        public static string LOANPRODUCTNAME => androidJavaClass.GetStatic<string>("LOANPRODUCTNAME");
        public static string LOANCHANNEL => androidJavaClass.GetStatic<string>("LOANCHANNEL");
        public static string REPAYMENTMETHOD => androidJavaClass.GetStatic<string>("REPAYMENTMETHOD");
        public static string ACTION => androidJavaClass.GetStatic<string>("ACTION");
        public static string PAGE => androidJavaClass.GetStatic<string>("PAGE");
        public static string INDEX => androidJavaClass.GetStatic<string>("INDEX");
        public static string MODULE => androidJavaClass.GetStatic<string>("MODULE");
        public static string SOURCEPAGE => androidJavaClass.GetStatic<string>("SOURCEPAGE");
        public static string SOURCEPAGENAME => androidJavaClass.GetStatic<string>("SOURCEPAGENAME");
        public static string SOURCELOCATION => androidJavaClass.GetStatic<string>("SOURCELOCATION");
        public static string CITY => androidJavaClass.GetStatic<string>("CITY");
        public static string FROMCITY => androidJavaClass.GetStatic<string>("FROMCITY");
        public static string TOCITY => androidJavaClass.GetStatic<string>("TOCITY");
        public static string DEPARTUREDATE => androidJavaClass.GetStatic<string>("DEPARTUREDATE");
        public static string RETURNDATE => androidJavaClass.GetStatic<string>("RETURNDATE");
        public static string TRIPTYPE => androidJavaClass.GetStatic<string>("TRIPTYPE");
        public static string SEARCHHOTEL => androidJavaClass.GetStatic<string>("SEARCHHOTEL");
        public static string SPECIALTICKET => androidJavaClass.GetStatic<string>("SPECIALTICKET");
        public static string HASBABY => androidJavaClass.GetStatic<string>("HASBABY");
        public static string HASCHILDREN => androidJavaClass.GetStatic<string>("HASCHILDREN");
        public static string COUNTRY => androidJavaClass.GetStatic<string>("COUNTRY");
        public static string STAR => androidJavaClass.GetStatic<string>("STAR");
        public static string CHECKINDATE => androidJavaClass.GetStatic<string>("CHECKINDATE");
        public static string CHECKOUTDATE => androidJavaClass.GetStatic<string>("CHECKOUTDATE");
        public static string ALDULTCOUNT => androidJavaClass.GetStatic<string>("ALDULTCOUNT");
        public static string BABYCOUNT => androidJavaClass.GetStatic<string>("BABYCOUNT");
        public static string CHILDRENCOUNT => androidJavaClass.GetStatic<string>("CHILDRENCOUNT");
        public static string FROM => androidJavaClass.GetStatic<string>("FROM");
        public static string CARMODE => androidJavaClass.GetStatic<string>("CARMODE");
        public static string CARTIME => androidJavaClass.GetStatic<string>("CARTIME");
        public static string FLIGHTID => androidJavaClass.GetStatic<string>("FLIGHTID");
        public static string SEARCHRESULT => androidJavaClass.GetStatic<string>("SEARCHRESULT");
        public static string PRODUCT => androidJavaClass.GetStatic<string>("PRODUCT");
        public static string DEPARTURETIME => androidJavaClass.GetStatic<string>("DEPARTURETIME");
        public static string ARRIVETIME => androidJavaClass.GetStatic<string>("ARRIVETIME");
        public static string DEPARTUREAIRPORT => androidJavaClass.GetStatic<string>("DEPARTUREAIRPORT");
        public static string ARRIVEEAIRPORT => androidJavaClass.GetStatic<string>("ARRIVEEAIRPORT");
        public static string AIRLINE => androidJavaClass.GetStatic<string>("AIRLINE");
        public static string FLIGHTTYPE => androidJavaClass.GetStatic<string>("FLIGHTTYPE");
        public static string DIRECTFLIGHT => androidJavaClass.GetStatic<string>("DIRECTFLIGHT");
        public static string TRAINTYPE => androidJavaClass.GetStatic<string>("TRAINTYPE");
        public static string FROMSTATION => androidJavaClass.GetStatic<string>("FROMSTATION");
        public static string BEDTYPE => androidJavaClass.GetStatic<string>("BEDTYPE");
        public static string BREAKFAST => androidJavaClass.GetStatic<string>("BREAKFAST");
        public static string ARRIVEDATE => androidJavaClass.GetStatic<string>("ARRIVEDATE");
        public static string TRAINID => androidJavaClass.GetStatic<string>("TRAINID");
        public static string HOTELID => androidJavaClass.GetStatic<string>("HOTELID");
        public static string HOTELNAME => androidJavaClass.GetStatic<string>("HOTELNAME");
        public static string TRIPTAG => androidJavaClass.GetStatic<string>("TRIPTAG");
        public static string HOTELTYPE => androidJavaClass.GetStatic<string>("HOTELTYPE");
        public static string CABIN => androidJavaClass.GetStatic<string>("CABIN");
        public static string ROOMTYPE => androidJavaClass.GetStatic<string>("ROOMTYPE");
        public static string CARTYPE => androidJavaClass.GetStatic<string>("CARTYPE");
        public static string SUPPLIER => androidJavaClass.GetStatic<string>("SUPPLIER");
        public static string STUDENTCOUNT => androidJavaClass.GetStatic<string>("STUDENTCOUNT");
        public static string ROOMCOUNT => androidJavaClass.GetStatic<string>("ROOMCOUNT");
        public static string PERSONCOUNT => androidJavaClass.GetStatic<string>("PERSONCOUNT");
        public static string VOUCHERID => androidJavaClass.GetStatic<string>("VOUCHERID");
        public static string VOUCHERNAME => androidJavaClass.GetStatic<string>("VOUCHERNAME");
        public static string VOUCHERPRICE => androidJavaClass.GetStatic<string>("VOUCHERPRICE");
        public static string USERTYPE => androidJavaClass.GetStatic<string>("USERTYPE");
        public static string TARGET => androidJavaClass.GetStatic<string>("TARGET");
        public static string ISCOMPELETED => androidJavaClass.GetStatic<string>("ISCOMPELETED");
        public static string USERLEVEL => androidJavaClass.GetStatic<string>("USERLEVEL");
        public static string TIME => androidJavaClass.GetStatic<string>("TIME");
        public static string DISTANCE => androidJavaClass.GetStatic<string>("DISTANCE");
        public static string CALORIECONSUMED => androidJavaClass.GetStatic<string>("CALORIECONSUMED");
        public static string PROGRESS => androidJavaClass.GetStatic<string>("PROGRESS");
        public static string MULTIPLEACCOUNTS => androidJavaClass.GetStatic<string>("MULTIPLEACCOUNTS");
        public static string ACCOUNTTYPE => androidJavaClass.GetStatic<string>("ACCOUNTTYPE");
        public static string FAILUREREASON => androidJavaClass.GetStatic<string>("FAILUREREASON");
        public static string AUTHORITY => androidJavaClass.GetStatic<string>("AUTHORITY");
        public static string CARDTYPE => androidJavaClass.GetStatic<string>("CARDTYPE");
        public static string ISSUEBANK => androidJavaClass.GetStatic<string>("ISSUEBANK");
        public static string TRANSFORMAMOUNT => androidJavaClass.GetStatic<string>("TRANSFORMAMOUNT");
        public static string BANKNAME => androidJavaClass.GetStatic<string>("BANKNAME");
        public static string SOURCEMODULE => androidJavaClass.GetStatic<string>("SOURCEMODULE");
        public static string STOCKCODE => androidJavaClass.GetStatic<string>("STOCKCODE");
        public static string STOCKNAME => androidJavaClass.GetStatic<string>("STOCKNAME");
        public static string MARKETCODE => androidJavaClass.GetStatic<string>("MARKETCODE");
        public static string MARKETNAME => androidJavaClass.GetStatic<string>("MARKETNAME");
        public static string VIEWTYPE => androidJavaClass.GetStatic<string>("VIEWTYPE");
        public static string TRENDCYCLE => androidJavaClass.GetStatic<string>("TRENDCYCLE");
        public static string TRANSACTIONTYPE => androidJavaClass.GetStatic<string>("TRANSACTIONTYPE");
        public static string CURRENCY => androidJavaClass.GetStatic<string>("CURRENCY");
        public static string MONEY => androidJavaClass.GetStatic<string>("MONEY");
        public static string FINANCEID => androidJavaClass.GetStatic<string>("FINANCEID");
        public static string FINANCENAME => androidJavaClass.GetStatic<string>("FINANCENAME");
        public static string FINANCETYPE => androidJavaClass.GetStatic<string>("FINANCETYPE");
        public static string FINANCERATE => androidJavaClass.GetStatic<string>("FINANCERATE");
        public static string FINANCETIMELIMIT => androidJavaClass.GetStatic<string>("FINANCETIMELIMIT");
        public static string FINANCEAMOUNTMIN => androidJavaClass.GetStatic<string>("FINANCEAMOUNTMIN");
        public static string FINANCERISKLEV => androidJavaClass.GetStatic<string>("FINANCERISKLEV");
        public static string PURCHASEAMOUNT => androidJavaClass.GetStatic<string>("PURCHASEAMOUNT");
        public static string HANDLINGFEES => androidJavaClass.GetStatic<string>("HANDLINGFEES");
        public static string REDEMPTIONAMOUNT => androidJavaClass.GetStatic<string>("REDEMPTIONAMOUNT");
        public static string RETURNAMOUNT => androidJavaClass.GetStatic<string>("RETURNAMOUNT");
        public static string FUNDCODE => androidJavaClass.GetStatic<string>("FUNDCODE");
        public static string FUNDTYPE => androidJavaClass.GetStatic<string>("FUNDTYPE");
        public static string FUNDNAME => androidJavaClass.GetStatic<string>("FUNDNAME");
        public static string FUNDRISKLEV => androidJavaClass.GetStatic<string>("FUNDRISKLEV");
        public static string CHARGERATE => androidJavaClass.GetStatic<string>("CHARGERATE");
        public static string PAYMENTMETHOD => androidJavaClass.GetStatic<string>("PAYMENTMETHOD");
        public static string FIXEDCYCLE => androidJavaClass.GetStatic<string>("FIXEDCYCLE");
        public static string ENTRANCE => androidJavaClass.GetStatic<string>("ENTRANCE");
        public static string CODE => androidJavaClass.GetStatic<string>("CODE");
        public static string NEWSTOPIC => androidJavaClass.GetStatic<string>("NEWSTOPIC");
        public static string INFORMATIONSOURCE => androidJavaClass.GetStatic<string>("INFORMATIONSOURCE");
        public static string COMMENTSNUMBER => androidJavaClass.GetStatic<string>("COMMENTSNUMBER");
        public static string FORWARDINGNUMBER => androidJavaClass.GetStatic<string>("FORWARDINGNUMBER");
        public static string LIKES => androidJavaClass.GetStatic<string>("LIKES");
        public static string TITLE => androidJavaClass.GetStatic<string>("TITLE");
        public static string SEARCHTYPE => androidJavaClass.GetStatic<string>("SEARCHTYPE");
        public static string LOCATION => androidJavaClass.GetStatic<string>("LOCATION");
        public static string ID => androidJavaClass.GetStatic<string>("ID");
        public static string PLAYMODE => androidJavaClass.GetStatic<string>("PLAYMODE");
        public static string LISTS => androidJavaClass.GetStatic<string>("LISTS");
        public static string ADLOCATION => androidJavaClass.GetStatic<string>("ADLOCATION");
        public static string ADCATEGORY => androidJavaClass.GetStatic<string>("ADCATEGORY");
        public static string ADTHEME => androidJavaClass.GetStatic<string>("ADTHEME");
        public static string BUTTONNAME => androidJavaClass.GetStatic<string>("BUTTONNAME");
        public static string USERID => androidJavaClass.GetStatic<string>("USERID");
        public static string PAGECATEGORY => androidJavaClass.GetStatic<string>("PAGECATEGORY");
        public static string RATING => androidJavaClass.GetStatic<string>("RATING");
        public static string PERFORMANCE => androidJavaClass.GetStatic<string>("PERFORMANCE");
        public static string TRADINGRULES => androidJavaClass.GetStatic<string>("TRADINGRULES");
        public static string PORTFOLIO => androidJavaClass.GetStatic<string>("PORTFOLIO");
        public static string INVESTMENTMANAGER => androidJavaClass.GetStatic<string>("INVESTMENTMANAGER");
        public static string FUNDSIZE => androidJavaClass.GetStatic<string>("FUNDSIZE");
        public static string VIPMONEY => androidJavaClass.GetStatic<string>("VIPMONEY");
        public static string VIPLOCATION => androidJavaClass.GetStatic<string>("VIPLOCATION");
        public static string VIPFAILED => androidJavaClass.GetStatic<string>("VIPFAILED");
        public static string PERMISSIONNAME => androidJavaClass.GetStatic<string>("PERMISSIONNAME");
    }
}
