using System.Collections.Generic;

namespace HuaweiMobileServices.IAP
{
	using IMessageEntity = com.huawei.hms.core.aidl.IMessageEntity;
	using Packed = com.huawei.hms.core.aidl.annotation.Packed;

	public class ProductInfoReq : IMessageEntity
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Packed private int priceType;
	  private int priceType;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Packed private java.util.List<String> skuIds;
	  private IList<string> skuIds;

	  public virtual int PriceType
	  {
		  get
		  {
			  return this.priceType;
		  }
		  set
		  {
			  this.priceType = value;
		  }
	  }

	  public virtual IList<string> ProductIds
	  {
		  get
		  {
			  return this.skuIds;
		  }
		  set
		  {
			  this.skuIds = value;
		  }
	  }


	}

}