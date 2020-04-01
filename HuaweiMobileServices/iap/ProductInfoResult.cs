using System.Collections.Generic;

namespace HuaweiMobileServices.IAP
{
	using Result = com.huawei.hms.support.api.client.Result;

	public class ProductInfoResult : Result
	{
	  private int returnCode;

	  private string errMsg;

	  private IList<ProductInfo> productInfoList;

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


	  public virtual IList<ProductInfo> ProductInfoList
	  {
		  get
		  {
			  return this.productInfoList;
		  }
		  set
		  {
			  this.productInfoList = value;
		  }
	  }

	}

}