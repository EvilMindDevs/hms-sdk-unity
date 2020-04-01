namespace HuaweiMobileServices.IAP
{
	using Result = com.huawei.hms.support.api.client.Result;

	public class ConsumeOwnedPurchaseResult : Result
	{
	  private string consumePurchaseData;

	  private string dataSignature;

	  private int returnCode;

	  private string errMsg;

	  public virtual string ConsumePurchaseData
	  {
		  get
		  {
			  return this.consumePurchaseData;
		  }
		  set
		  {
			  this.consumePurchaseData = value;
		  }
	  }


	  public virtual string DataSignature
	  {
		  get
		  {
			  return this.dataSignature;
		  }
		  set
		  {
			  this.dataSignature = value;
		  }
	  }


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

	}

}