namespace HuaweiMobileServices.IAP
{
	using Result = com.huawei.hms.support.api.client.Result;

	public class PurchaseIntentResult : Result
	{
	  private string paymentData;

	  private string paymentSignature;

	  private int returnCode;

	  private string errMsg;

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


	  public virtual string PaymentData
	  {
		  get
		  {
			  return this.paymentData;
		  }
		  set
		  {
			  this.paymentData = value;
		  }
	  }


	  public virtual string PaymentSignature
	  {
		  get
		  {
			  return this.paymentSignature;
		  }
		  set
		  {
			  this.paymentSignature = value;
		  }
	  }

	}

}