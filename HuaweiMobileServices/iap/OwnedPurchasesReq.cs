namespace HuaweiMobileServices.IAP
{
	using IMessageEntity = com.huawei.hms.core.aidl.IMessageEntity;
	using Packed = com.huawei.hms.core.aidl.annotation.Packed;

	public class OwnedPurchasesReq : IMessageEntity
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Packed private String continuationToken;
	  private string continuationToken;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Packed private int priceType;
	  private int priceType;

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


	}

}