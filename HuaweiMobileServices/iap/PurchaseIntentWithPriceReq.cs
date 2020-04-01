namespace HuaweiMobileServices.IAP
{
	using IMessageEntity = com.huawei.hms.core.aidl.IMessageEntity;
	using Packed = com.huawei.hms.core.aidl.annotation.Packed;

	public class PurchaseIntentWithPriceReq : IMessageEntity
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Packed private String productId;
	  private string productId;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Packed private int priceType;
	  private int priceType;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Packed private String productName;
	  private string productName;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Packed private String amount;
	  private string amount;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Packed private String country;
	  private string country;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Packed private String currency;
	  private string currency;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Packed private String sdkChannel;
	  private string sdkChannel;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Packed private String serviceCatalog;
	  private string serviceCatalog;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Packed private String developerPayload;
	  private string developerPayload;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Packed private String transactionId = createTransactionId();
	  private string transactionId = createTransactionId();

	  private static string createTransactionId()
	  { // Byte code:
		//   0: new java/lang/StringBuilder
		//   3: dup
		//   4: invokespecial <init> : ()V
		//   7: invokestatic currentTimeMillis : ()J
		//   10: invokevirtual append : (J)Ljava/lang/StringBuilder;
		//   13: invokevirtual toString : ()Ljava/lang/String;
		//   16: astore_0
		//   17: new java/security/SecureRandom
		//   20: dup
		//   21: invokespecial <init> : ()V
		//   24: astore_1
		//   25: getstatic java/util/Locale.ENGLISH : Ljava/util/Locale;
		//   28: ldc '%06d'
		//   30: iconst_1
		//   31: anewarray java/lang/Object
		//   34: dup
		//   35: iconst_0
		//   36: aload_1
		//   37: ldc 1000000
		//   39: invokevirtual nextInt : (I)I
		//   42: invokestatic valueOf : (I)Ljava/lang/Integer;
		//   45: aastore
		//   46: invokestatic format : (Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;
		//   49: astore_1
		//   50: new java/lang/StringBuilder
		//   53: dup
		//   54: invokespecial <init> : ()V
		//   57: aload_0
		//   58: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   61: aload_1
		//   62: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   65: invokevirtual toString : ()Ljava/lang/String;
		//   68: areturn
		// Line number table:
		//   Java source line number -> byte code offset
		//   #93	-> 0
		//   #95	-> 17
		//   #97	-> 25
		//   #98	-> 50 }

	  public string ProductId
	  {
		  return this.productId;
	  }

	  public int PriceType
	  {
		  return this.priceType;
	  }

	  public string ProductName
	  {
		  return this.productName;
	  }

	  public string Amount
	  {
		  return this.amount;
	  }

	  public string Country
	  {
		  return this.country;
	  }

	  public string Currency
	  {
		  return this.currency;
	  }

	  public string SdkChannel
	  {
		  return this.sdkChannel;
	  }

	  public string ServiceCatalog
	  {
		  return this.serviceCatalog;
	  }

	  public string DeveloperPayload
	  {
		  return this.developerPayload;
	  }

	  public void setProductId(string paramString)
	  {
		  this.productId = paramString;
	  }

	  public void setPriceType(int paramInt)
	  {
		  this.priceType = paramInt;
	  }

	  public void setProductName(string paramString)
	  {
		  this.productName = paramString;
	  }

	  public void setAmount(string paramString)
	  {
		  this.amount = paramString;
	  }

	  public void setCountry(string paramString)
	  {
		  this.country = paramString;
	  }

	  public void setCurrency(string paramString)
	  {
		  this.currency = paramString;
	  }

	  public void setSdkChannel(string paramString)
	  {
		  this.sdkChannel = paramString;
	  }

	  public void setServiceCatalog(string paramString)
	  {
		  this.serviceCatalog = paramString;
	  }

	  public void setDeveloperPayload(string paramString)
	  {
		  this.developerPayload = paramString;
	  }
	  }

	}