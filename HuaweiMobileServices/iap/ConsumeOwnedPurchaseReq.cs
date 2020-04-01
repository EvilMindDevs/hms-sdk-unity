namespace HuaweiMobileServices.IAP
{

	public class ConsumeOwnedPurchaseReq : IMessageEntity
	{

	  private string purchaseToken;
	  private string developerChallenge;

	  public virtual string PurchaseToken
	  {
		  set
		  {
			  this.purchaseToken = value;
		  }
		  get
		  {
			  return this.purchaseToken;
		  }
	  }

	  public virtual string DeveloperChallenge
	  {
		  set
		  {
			  this.developerChallenge = value;
		  }
		  get
		  {
			  return this.developerChallenge;
		  }
	  }


	}

}