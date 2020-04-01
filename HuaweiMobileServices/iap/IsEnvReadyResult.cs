namespace HuaweiMobileServices.IAP
{
	using Result = com.huawei.hms.support.api.client.Result;

	public class IsEnvReadyResult : Result
	{
	  private int returnCode;

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

	}

}