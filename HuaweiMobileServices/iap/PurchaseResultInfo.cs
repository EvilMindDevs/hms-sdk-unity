namespace HuaweiMobileServices.IAP
{
	public class PurchaseResultInfo
	{
	  private int a;

	  private string b;

	  private string c;

	  private string d;

	  public virtual int ReturnCode
	  {
		  get
		  {
			  return this.a;
		  }
		  set
		  {
			  this.a = value;
		  }
	  }


	  public virtual string ErrMsg
	  {
		  get
		  {
			  return this.d;
		  }
		  set
		  {
			  this.d = value;
		  }
	  }


	  public virtual string InAppPurchaseData
	  {
		  get
		  {
			  return this.b;
		  }
		  set
		  {
			  this.b = value;
		  }
	  }


	  public virtual string InAppDataSignature
	  {
		  get
		  {
			  return this.c;
		  }
		  set
		  {
			  this.c = value;
		  }
	  }

	}

}