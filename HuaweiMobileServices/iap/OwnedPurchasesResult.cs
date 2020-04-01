using System.Collections.Generic;

namespace HuaweiMobileServices.IAP
{
	using Result = com.huawei.hms.support.api.client.Result;

	public class OwnedPurchasesResult : Result
	{
	  private int returnCode;

	  private string errMsg;

	  private IList<string> itemList;

	  private IList<string> inAppPurchaseDataList;

	  private IList<string> inAppSignature;

	  private string continuationToken;

	  private IList<string> placedInappPurchaseDataList;

	  private IList<string> placedInappSignatureList;

	  public virtual int ReturnCode
	  {
		  get
		  {
			  return this.returnCode;
		  }
		  set
		  {
			  this.returnCode = value;
		  }
	  }


	  public virtual string ErrMsg
	  {
		  get
		  {
			  return this.errMsg;
		  }
		  set
		  {
			  this.errMsg = value;
		  }
	  }


	  public virtual string ContinuationToken
	  {
		  get
		  {
			  return this.continuationToken;
		  }
		  set
		  {
			  this.continuationToken = value;
		  }
	  }


	  public virtual IList<string> ItemList
	  {
		  get
		  {
			  return this.itemList;
		  }
		  set
		  {
			  this.itemList = value;
		  }
	  }


	  public virtual IList<string> InAppSignature
	  {
		  get
		  {
			  return this.inAppSignature;
		  }
		  set
		  {
			  this.inAppSignature = value;
		  }
	  }


	  public virtual IList<string> InAppPurchaseDataList
	  {
		  get
		  {
			  return this.inAppPurchaseDataList;
		  }
		  set
		  {
			  this.inAppPurchaseDataList = value;
		  }
	  }


	  public virtual IList<string> PlacedInappPurchaseDataList
	  {
		  get
		  {
			  return this.placedInappPurchaseDataList;
		  }
		  set
		  {
			  this.placedInappPurchaseDataList = value;
		  }
	  }


	  public virtual IList<string> PlacedInappSignatureList
	  {
		  get
		  {
			  return this.placedInappSignatureList;
		  }
		  set
		  {
			  this.placedInappSignatureList = value;
		  }
	  }

	}

}